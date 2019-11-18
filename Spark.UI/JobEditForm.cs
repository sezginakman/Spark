using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Spark.DataAccess;
using Spark.DataAccess.Util;
using Spark.JobUpdater;
using System.Configuration;
using Spark.Cores;

namespace Spark.UI
{
    public partial class JobEditForm : DevExpress.XtraEditors.XtraForm
    {
        private const string ConnectionString =
            "Server=192.168.5.28;Database=Hangfire_DB;User Id=AppUser;Password=&WD#fF4w+";
        private JobSettings _current;
        public JobSettings _clone;
        public JobEditForm()
        {
            InitializeComponent();
            InitializeRepositories();
        }
        public void SetCurrent(JobSettings settings)
        {
            _current = settings;
            _current.Clone(_clone);
            this.jobSettingsBindingSource.DataSource = _current;
            if (_current.Schedule == null) _current.Schedule = new Never();
            if (_current.Parameter == null) _current.Parameter = new List<KeyValue>();
            this.ScheduleComboBoxEdit.EditValueChanged -=
                new System.EventHandler(this.ScheduleComboBoxEdit_EditValueChanged);
            ScheduleComboBoxEdit.EditValue = null;
            ScheduleComboBoxEdit.EditValue = _current.Schedule.GetType().Name;
            LoadScheduleLayout(_current.Schedule);
            this.ScheduleComboBoxEdit.EditValueChanged += new System.EventHandler(this.ScheduleComboBoxEdit_EditValueChanged);
            keyValueBindingSource.DataSource = _current;
            keyValueBindingSource.DataMember = "Parameter";
            this.Text = _current.Key + @" Edit";
        }
        private void InitializeRepositories()
        {
            var schedules = new TimeExpressionService().GetAllEntities();
            foreach (var schedule in schedules)
                if (ScheduleComboBoxEdit.Properties.Items.Contains(schedule) == false)
                    ScheduleComboBoxEdit.Properties.Items.Add(schedule);
        }
        private void LoadScheduleLayout(ITimeExpressions schedule)
        {
            this.schedulerLayoutControl.DataSource = schedule;
            this.schedulerLayoutControl.RetrieveFields(new RetrieveFieldsParameters()
            {
                DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged,
                CreateRepositoryItems = false
            });
        }
        private void ScheduleComboBoxEdit_EditValueChanged(object sender, EventArgs e)
        {
            var scheduleName = ScheduleComboBoxEdit.EditValue.ToString();
            var schedule = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ITimeExpressions).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .FirstOrDefault(x => x.Name == scheduleName);
            if (schedule == null) return;
            _current.Schedule = (ITimeExpressions)Activator.CreateInstance(schedule,
                BindingFlags.CreateInstance |
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.OptionalParamBinding,
                null, new[] { Type.Missing }, CultureInfo.CurrentCulture);
            LoadScheduleLayout(_current.Schedule);
        }

        private void ParameterGridView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (DateTime.TryParse(e.CellValue?.ToString(), out var datetime))
                e.RepositoryItem = new RepositoryItemDateEdit() { CalendarTimeEditing = DefaultBoolean.True };
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                this.jobSettingsBindingSource.EndEdit();
                await new JobSettingsService().SaveAsync(_current);
                new EnqueueJob(ConnectionString).Update(_current.Key);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.jobSettingsBindingSource.EndEdit();
            _clone.Clone(_current);
            this.jobSettingsBindingSource.EndEdit();
            this.DialogResult = DialogResult.Cancel;
        }

        private  void RemoveButton_Click(object sender, EventArgs e)
        {
            new EnqueueJob(ConnectionString).Remove(_current.Key);
             new JobSettingsService().DeleteByKey(_current.Key);
             this.DialogResult = DialogResult.OK;
        }
    }
}
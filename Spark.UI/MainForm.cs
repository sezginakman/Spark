using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using Spark.Cores;
using Spark.DataAccess;
namespace Spark.UI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                splashScreenManager.ShowWaitForm();
                this.jobSettingsBindingSource.DataSource = new JobSettingsService().GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                splashScreenManager.CloseWaitForm();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void jobTileView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colSchedule && e.Value != null)
                e.DisplayText =
                    $@"{e.Value.GetType().Name}(  {string.Join(", ", e.Value.GetType().GetProperties().Select(f => f.Name + " : " + f.GetValue(e.Value).ToString()).ToList())} )";
        }
        private void jobTileView_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            if (this.jobTileView.GetFocusedRow() is JobSettings job)
            {
                using (var editForm = new JobEditForm())
                {
                    editForm.SetCurrent(job);
                    var dialogResult = editForm.ShowDialog(this);
                    jobTileView.UpdateCurrentRow();
                    LoadData();
                }
            }
        }
    }
}
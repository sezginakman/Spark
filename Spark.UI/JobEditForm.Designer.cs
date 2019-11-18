using System.Collections.Generic;
using Spark.Cores;

namespace Spark.UI
{
    partial class JobEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.RemoveButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ParameterGridControl = new DevExpress.XtraGrid.GridControl();
            this.keyValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParameterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.schedulerLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GroupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jobSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KeyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IsActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.JobTypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ScheduleComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForGroup = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForJobType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIsActive = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForKey = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSchedule = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Spark.UI.LoadingForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobTypeImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.RemoveButton);
            this.panelControl1.Controls.Add(this.SaveButton);
            this.panelControl1.Controls.Add(this.cancelButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 364);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(611, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 12);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove Job";
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(430, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(511, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.ParameterGridControl);
            this.dataLayoutControl1.Controls.Add(this.schedulerLayoutControl);
            this.dataLayoutControl1.Controls.Add(this.GroupTextEdit);
            this.dataLayoutControl1.Controls.Add(this.KeyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsActiveCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.JobTypeImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.ScheduleComboBoxEdit);
            this.dataLayoutControl1.DataSource = this.jobSettingsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(611, 364);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ParameterGridControl
            // 
            this.ParameterGridControl.DataSource = this.keyValueBindingSource;
            this.ParameterGridControl.Location = new System.Drawing.Point(270, 114);
            this.ParameterGridControl.MainView = this.ParameterGridView;
            this.ParameterGridControl.Name = "ParameterGridControl";
            this.ParameterGridControl.Size = new System.Drawing.Size(317, 226);
            this.ParameterGridControl.TabIndex = 11;
            this.ParameterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ParameterGridView});
            // 
            // keyValueBindingSource
            // 
            this.keyValueBindingSource.AllowNew = true;
            this.keyValueBindingSource.DataSource = typeof(System.Collections.Generic.KeyValuePair<string, object>);
            // 
            // ParameterGridView
            // 
            this.ParameterGridView.GridControl = this.ParameterGridControl;
            this.ParameterGridView.Name = "ParameterGridView";
            this.ParameterGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.ParameterGridView.OptionsView.ShowGroupPanel = false;
            this.ParameterGridView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.ParameterGridView_CustomRowCellEdit);
            // 
            // schedulerLayoutControl
            // 
            this.schedulerLayoutControl.Location = new System.Drawing.Point(24, 138);
            this.schedulerLayoutControl.Name = "schedulerLayoutControl";
            this.schedulerLayoutControl.Root = this.layoutControlGroup4;
            this.schedulerLayoutControl.Size = new System.Drawing.Size(218, 202);
            this.schedulerLayoutControl.TabIndex = 10;
            this.schedulerLayoutControl.Text = "dataLayoutControl2";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(218, 202);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // GroupTextEdit
            // 
            this.GroupTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobSettingsBindingSource, "Group", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GroupTextEdit.Location = new System.Drawing.Point(358, 35);
            this.GroupTextEdit.Name = "GroupTextEdit";
            this.GroupTextEdit.Size = new System.Drawing.Size(241, 20);
            this.GroupTextEdit.StyleController = this.dataLayoutControl1;
            this.GroupTextEdit.TabIndex = 4;
            // 
            // jobSettingsBindingSource
            // 
            this.jobSettingsBindingSource.DataSource = typeof(JobSettings);
            // 
            // KeyTextEdit
            // 
            this.KeyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobSettingsBindingSource, "Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.KeyTextEdit.Location = new System.Drawing.Point(59, 35);
            this.KeyTextEdit.Name = "KeyTextEdit";
            this.KeyTextEdit.Size = new System.Drawing.Size(248, 20);
            this.KeyTextEdit.StyleController = this.dataLayoutControl1;
            this.KeyTextEdit.TabIndex = 5;
            // 
            // IsActiveCheckEdit
            // 
            this.IsActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobSettingsBindingSource, "IsActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IsActiveCheckEdit.Location = new System.Drawing.Point(12, 12);
            this.IsActiveCheckEdit.Name = "IsActiveCheckEdit";
            this.IsActiveCheckEdit.Properties.Caption = "Is Active";
            this.IsActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsActiveCheckEdit.Size = new System.Drawing.Size(587, 19);
            this.IsActiveCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsActiveCheckEdit.TabIndex = 6;
            // 
            // JobTypeImageComboBoxEdit
            // 
            this.JobTypeImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobSettingsBindingSource, "JobType", true));
            this.JobTypeImageComboBoxEdit.Location = new System.Drawing.Point(59, 59);
            this.JobTypeImageComboBoxEdit.Name = "JobTypeImageComboBoxEdit";
            this.JobTypeImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.JobTypeImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JobTypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.JobTypeImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("FireAndForget", JobType.FireAndForget, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Delayed", JobType.Delayed, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Repeated", JobType.Repeated, 2)});
            this.JobTypeImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.JobTypeImageComboBoxEdit.Size = new System.Drawing.Size(540, 20);
            this.JobTypeImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.JobTypeImageComboBoxEdit.TabIndex = 7;
            // 
            // ScheduleComboBoxEdit
            // 
            this.ScheduleComboBoxEdit.AllowDrop = true;
            this.ScheduleComboBoxEdit.Location = new System.Drawing.Point(71, 114);
            this.ScheduleComboBoxEdit.Name = "ScheduleComboBoxEdit";
            this.ScheduleComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ScheduleComboBoxEdit.Size = new System.Drawing.Size(171, 20);
            this.ScheduleComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.ScheduleComboBoxEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(611, 364);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForGroup,
            this.ItemForJobType,
            this.ItemForIsActive,
            this.ItemForKey,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(591, 344);
            // 
            // ItemForGroup
            // 
            this.ItemForGroup.Control = this.GroupTextEdit;
            this.ItemForGroup.Location = new System.Drawing.Point(299, 23);
            this.ItemForGroup.Name = "ItemForGroup";
            this.ItemForGroup.Size = new System.Drawing.Size(292, 24);
            this.ItemForGroup.Text = "Group";
            this.ItemForGroup.TextSize = new System.Drawing.Size(44, 13);
            // 
            // ItemForJobType
            // 
            this.ItemForJobType.Control = this.JobTypeImageComboBoxEdit;
            this.ItemForJobType.Location = new System.Drawing.Point(0, 47);
            this.ItemForJobType.Name = "ItemForJobType";
            this.ItemForJobType.Size = new System.Drawing.Size(591, 24);
            this.ItemForJobType.Text = "Job Type";
            this.ItemForJobType.TextSize = new System.Drawing.Size(44, 13);
            // 
            // ItemForIsActive
            // 
            this.ItemForIsActive.Control = this.IsActiveCheckEdit;
            this.ItemForIsActive.Location = new System.Drawing.Point(0, 0);
            this.ItemForIsActive.Name = "ItemForIsActive";
            this.ItemForIsActive.Size = new System.Drawing.Size(591, 23);
            this.ItemForIsActive.Text = "Is Active";
            this.ItemForIsActive.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsActive.TextVisible = false;
            // 
            // ItemForKey
            // 
            this.ItemForKey.Control = this.KeyTextEdit;
            this.ItemForKey.Location = new System.Drawing.Point(0, 23);
            this.ItemForKey.Name = "ItemForKey";
            this.ItemForKey.Size = new System.Drawing.Size(299, 24);
            this.ItemForKey.Text = "Key";
            this.ItemForKey.TextSize = new System.Drawing.Size(44, 13);
            this.ItemForKey.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(246, 71);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(345, 273);
            this.layoutControlGroup2.Text = "Job Parameters";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ParameterGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(321, 230);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSchedule,
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 71);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(246, 273);
            this.layoutControlGroup3.Text = "Scheduler";
            // 
            // ItemForSchedule
            // 
            this.ItemForSchedule.Control = this.ScheduleComboBoxEdit;
            this.ItemForSchedule.Location = new System.Drawing.Point(0, 0);
            this.ItemForSchedule.Name = "ItemForSchedule";
            this.ItemForSchedule.Size = new System.Drawing.Size(222, 24);
            this.ItemForSchedule.Text = "Schedule";
            this.ItemForSchedule.TextSize = new System.Drawing.Size(44, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.schedulerLayoutControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(222, 206);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // JobEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 411);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "JobEditForm";
            this.Text = "JobEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobTypeImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit GroupTextEdit;
        private System.Windows.Forms.BindingSource jobSettingsBindingSource;
        private DevExpress.XtraEditors.TextEdit KeyTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsActiveCheckEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit JobTypeImageComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit ScheduleComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGroup;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsActive;
        private DevExpress.XtraLayout.LayoutControlItem ItemForKey;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSchedule;
        private DevExpress.XtraDataLayout.DataLayoutControl schedulerLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl ParameterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ParameterGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource keyValueBindingSource;
        private DevExpress.XtraEditors.SimpleButton RemoveButton;
    }
}
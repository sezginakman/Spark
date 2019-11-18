using Spark.Cores;

namespace Spark.UI
{
    partial class MainForm
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colJobType = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSchedule = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colKey = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.jobSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAssemblyQualifiedName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAssemblyFullName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAssemblyName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAssemblyFileName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colError = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGroup = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Spark.UI.LoadingForm), true, true);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // colJobType
            // 
            this.colJobType.FieldName = "JobType";
            this.colJobType.Name = "colJobType";
            this.colJobType.Visible = true;
            this.colJobType.VisibleIndex = 3;
            // 
            // colSchedule
            // 
            this.colSchedule.FieldName = "Schedule";
            this.colSchedule.Name = "colSchedule";
            this.colSchedule.Visible = true;
            this.colSchedule.VisibleIndex = 4;
            // 
            // colKey
            // 
            this.colKey.FieldName = "Key";
            this.colKey.Name = "colKey";
            this.colKey.Visible = true;
            this.colKey.VisibleIndex = 1;
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.jobSettingsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 122);
            this.gridControl1.MainView = this.jobTileView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1005, 418);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jobTileView,
            this.layoutView1});
            // 
            // jobSettingsBindingSource
            // 
            this.jobSettingsBindingSource.DataSource = typeof(JobSettings);
            // 
            // jobTileView
            // 
            this.jobTileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKey,
            this.colIsActive,
            this.colJobType,
            this.colSchedule,
            this.colAssemblyQualifiedName,
            this.colAssemblyFullName,
            this.colAssemblyName,
            this.colAssemblyFileName,
            this.colError,
            this.colGroup});
            this.jobTileView.ColumnSet.CheckedColumn = this.colIsActive;
            this.jobTileView.ColumnSet.GroupColumn = this.colGroup;
            this.jobTileView.GridControl = this.gridControl1;
            this.jobTileView.Name = "jobTileView";
            this.jobTileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.jobTileView.OptionsTiles.RowCount = 0;
            this.jobTileView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.jobTileView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            tableColumnDefinition1.Length.Value = 158D;
            tableColumnDefinition2.Length.Value = 0D;
            tableColumnDefinition3.Length.Value = 22D;
            tableColumnDefinition4.Length.Value = 576D;
            this.jobTileView.TileColumns.Add(tableColumnDefinition1);
            this.jobTileView.TileColumns.Add(tableColumnDefinition2);
            this.jobTileView.TileColumns.Add(tableColumnDefinition3);
            this.jobTileView.TileColumns.Add(tableColumnDefinition4);
            tableRowDefinition1.Length.Value = 30D;
            tableRowDefinition2.Length.Value = 18D;
            tableRowDefinition3.Length.Value = 22D;
            tableRowDefinition4.Length.Value = 18D;
            tableRowDefinition5.Length.Value = 18D;
            this.jobTileView.TileRows.Add(tableRowDefinition1);
            this.jobTileView.TileRows.Add(tableRowDefinition2);
            this.jobTileView.TileRows.Add(tableRowDefinition3);
            this.jobTileView.TileRows.Add(tableRowDefinition4);
            this.jobTileView.TileRows.Add(tableRowDefinition5);
            tableSpan1.ColumnSpan = 4;
            tableSpan2.ColumnIndex = 2;
            tableSpan2.RowIndex = 1;
            tableSpan2.RowSpan = 4;
            tableSpan3.RowIndex = 1;
            tableSpan3.RowSpan = 3;
            this.jobTileView.TileSpans.Add(tableSpan1);
            this.jobTileView.TileSpans.Add(tableSpan2);
            this.jobTileView.TileSpans.Add(tableSpan3);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.LightSlateGray;
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement1.ColumnIndex = 3;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "Job Type";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement2.Column = this.colJobType;
            tileViewItemElement2.ColumnIndex = 3;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 2;
            tileViewItemElement2.Text = "colJobType";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            tileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.LightSlateGray;
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement3.ColumnIndex = 3;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 3;
            tileViewItemElement3.Text = "Schedule";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement4.Column = this.colSchedule;
            tileViewItemElement4.ColumnIndex = 3;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 4;
            tileViewItemElement4.Text = "colSchedule";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement5.ImageOptions.Image = global::Spark.UI.Properties.Resources.robot1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 2;
            tileViewItemElement5.Text = "Image";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement5.TextVisible = false;
            tileViewItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tileViewItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.DodgerBlue;
            tileViewItemElement6.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement6.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement6.Column = this.colKey;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.Text = "colKey";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.jobTileView.TileTemplate.Add(tileViewItemElement1);
            this.jobTileView.TileTemplate.Add(tileViewItemElement2);
            this.jobTileView.TileTemplate.Add(tileViewItemElement3);
            this.jobTileView.TileTemplate.Add(tileViewItemElement4);
            this.jobTileView.TileTemplate.Add(tileViewItemElement5);
            this.jobTileView.TileTemplate.Add(tileViewItemElement6);
            this.jobTileView.ItemDoubleClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.jobTileView_ItemDoubleClick);
            this.jobTileView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.jobTileView_CustomColumnDisplayText);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            // 
            // colAssemblyQualifiedName
            // 
            this.colAssemblyQualifiedName.FieldName = "AssemblyQualifiedName";
            this.colAssemblyQualifiedName.Name = "colAssemblyQualifiedName";
            this.colAssemblyQualifiedName.Visible = true;
            this.colAssemblyQualifiedName.VisibleIndex = 5;
            // 
            // colAssemblyFullName
            // 
            this.colAssemblyFullName.FieldName = "AssemblyFullName";
            this.colAssemblyFullName.Name = "colAssemblyFullName";
            this.colAssemblyFullName.Visible = true;
            this.colAssemblyFullName.VisibleIndex = 6;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Visible = true;
            this.colAssemblyName.VisibleIndex = 7;
            // 
            // colAssemblyFileName
            // 
            this.colAssemblyFileName.FieldName = "AssemblyFileName";
            this.colAssemblyFileName.Name = "colAssemblyFileName";
            this.colAssemblyFileName.Visible = true;
            this.colAssemblyFileName.VisibleIndex = 8;
            // 
            // colError
            // 
            this.colError.FieldName = "Error";
            this.colError.Name = "colError";
            this.colError.Visible = true;
            this.colError.VisibleIndex = 9;
            // 
            // colGroup
            // 
            this.colGroup.FieldName = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.Visible = true;
            this.colGroup.VisibleIndex = 10;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel1.ID = new System.Guid("b16730b2-d524-45b4-ac3f-07a7e9a807a9");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 122);
            this.dockPanel1.Size = new System.Drawing.Size(1005, 122);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.RefreshButton);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(997, 92);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(23, 30);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 540);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1005, 43);
            this.panelControl1.TabIndex = 1;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 583);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource jobSettingsBindingSource;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Tile.TileView jobTileView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colKey;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIsActive;
        private DevExpress.XtraGrid.Columns.TileViewColumn colJobType;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSchedule;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAssemblyQualifiedName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAssemblyFullName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAssemblyName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAssemblyFileName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colError;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGroup;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
namespace UpdateDataBase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuDataBaseTabel = new DevExpress.XtraBars.BarSubItem();
            this.BtnImportTblFromDataBase = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateNewDatabaseTable = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDBSetting = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.mnuDataBaseTabel,
            this.barButtonItem1,
            this.BtnImportTblFromDataBase,
            this.btnCreateNewDatabaseTable,
            this.btnDBSetting});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
            // 
            // mnuDataBaseTabel
            // 
            this.mnuDataBaseTabel.Caption = "DataBase Tables";
            this.mnuDataBaseTabel.Id = 1;
            this.mnuDataBaseTabel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuDataBaseTabel.ImageOptions.Image")));
            this.mnuDataBaseTabel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuDataBaseTabel.ImageOptions.LargeImage")));
            this.mnuDataBaseTabel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnImportTblFromDataBase, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCreateNewDatabaseTable)});
            this.mnuDataBaseTabel.Name = "mnuDataBaseTabel";
            // 
            // BtnImportTblFromDataBase
            // 
            this.BtnImportTblFromDataBase.Caption = "Import Table From DB";
            this.BtnImportTblFromDataBase.Id = 3;
            this.BtnImportTblFromDataBase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnImportTblFromDataBase.ImageOptions.Image")));
            this.BtnImportTblFromDataBase.Name = "BtnImportTblFromDataBase";
            this.BtnImportTblFromDataBase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCreateNewDatabaseTable
            // 
            this.btnCreateNewDatabaseTable.Caption = "Create New DataBase Table";
            this.btnCreateNewDatabaseTable.Id = 4;
            this.btnCreateNewDatabaseTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNewDatabaseTable.ImageOptions.Image")));
            this.btnCreateNewDatabaseTable.Name = "btnCreateNewDatabaseTable";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDBSetting
            // 
            this.btnDBSetting.Caption = "DataBase Setting";
            this.btnDBSetting.Id = 6;
            this.btnDBSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnDBSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnDBSetting.Name = "btnDBSetting";
            this.btnDBSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDBSetting_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuDataBaseTabel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDBSetting);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarSubItem mnuDataBaseTabel;
        private DevExpress.XtraBars.BarButtonItem BtnImportTblFromDataBase;
        private DevExpress.XtraBars.BarButtonItem btnCreateNewDatabaseTable;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDBSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}


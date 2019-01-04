namespace LibraryManagement_Beta
{
    partial class frmBookDefine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookDefine));
            this.aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.kategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yazari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barkodno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sayfasayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.yayinevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // aciklama
            // 
            this.aciklama.Caption = "AÇIKLAMA";
            this.aciklama.FieldName = "aciklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.Visible = true;
            this.aciklama.VisibleIndex = 7;
            this.aciklama.Width = 73;
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "female.png");
            this.ımageCollection1.Images.SetKeyName(1, "male.png");
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Erkek", ((byte)(1)), 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kadın", ((byte)(2)), 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.ımageCollection1;
            // 
            // kategori
            // 
            this.kategori.Caption = "Kategori";
            this.kategori.FieldName = "kategori";
            this.kategori.Name = "kategori";
            this.kategori.Visible = true;
            this.kategori.VisibleIndex = 6;
            this.kategori.Width = 46;
            // 
            // location
            // 
            this.location.Caption = "Location";
            this.location.FieldName = "location";
            this.location.Name = "location";
            this.location.Visible = true;
            this.location.VisibleIndex = 5;
            this.location.Width = 46;
            // 
            // yazari
            // 
            this.yazari.Caption = "Yazar";
            this.yazari.FieldName = "yazari";
            this.yazari.Name = "yazari";
            this.yazari.Visible = true;
            this.yazari.VisibleIndex = 4;
            this.yazari.Width = 46;
            // 
            // barkodno
            // 
            this.barkodno.Caption = "Barkod No";
            this.barkodno.FieldName = "barkodno";
            this.barkodno.Name = "barkodno";
            this.barkodno.Visible = true;
            this.barkodno.VisibleIndex = 3;
            this.barkodno.Width = 70;
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.Caption = "Sayfa Sayısı";
            this.sayfasayisi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sayfasayisi.FieldName = "sayfasayisi";
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Visible = true;
            this.sayfasayisi.VisibleIndex = 1;
            this.sayfasayisi.Width = 53;
            // 
            // ad
            // 
            this.ad.Caption = "AD";
            this.ad.FieldName = "ad";
            this.ad.Name = "ad";
            this.ad.Visible = true;
            this.ad.VisibleIndex = 0;
            this.ad.Width = 53;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.Name = "id";
            this.id.Width = 20;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.ad,
            this.sayfasayisi,
            this.yayinevi,
            this.barkodno,
            this.yazari,
            this.location,
            this.kategori,
            this.aciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // yayinevi
            // 
            this.yayinevi.Caption = "Yayın Evi";
            this.yayinevi.FieldName = "yayinevi";
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Visible = true;
            this.yayinevi.VisibleIndex = 2;
            this.yayinevi.Width = 90;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(1115, 407);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "İşlemler";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Kaydet";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Kaydet Kapat";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Kapat";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "İşlemler";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1115, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // frmBookDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "frmBookDefine";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "KİTAP TANIMLARI";
            this.Load += new System.EventHandler(this.frmBookDefine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn aciklama;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn kategori;
        private DevExpress.XtraGrid.Columns.GridColumn location;
        private DevExpress.XtraGrid.Columns.GridColumn yazari;
        private DevExpress.XtraGrid.Columns.GridColumn barkodno;
        private DevExpress.XtraGrid.Columns.GridColumn sayfasayisi;
        private DevExpress.XtraGrid.Columns.GridColumn ad;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn yayinevi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
    }
}
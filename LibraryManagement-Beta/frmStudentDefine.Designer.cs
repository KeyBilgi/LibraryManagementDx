namespace LibraryManagement_Beta
{
    partial class frmStudentDefine
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentDefine));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.anaad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.babaad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.okul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sinif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            this.SuspendLayout();
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
            this.mainRibbonControl.Size = new System.Drawing.Size(1194, 146);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 146);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(1194, 450);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.ad,
            this.soyad,
            this.dtarih,
            this.tc,
            this.anaad,
            this.babaad,
            this.adres,
            this.tel,
            this.mail,
            this.cinsiyet,
            this.okul,
            this.sinif,
            this.donem,
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
            // id
            // 
            this.id.Caption = "id";
            this.id.Name = "id";
            this.id.Width = 20;
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
            // soyad
            // 
            this.soyad.Caption = "SOYAD";
            this.soyad.FieldName = "soyad";
            this.soyad.Name = "soyad";
            this.soyad.Visible = true;
            this.soyad.VisibleIndex = 1;
            this.soyad.Width = 53;
            // 
            // dtarih
            // 
            this.dtarih.Caption = "Doğum Tarihi";
            this.dtarih.DisplayFormat.FormatString = "d";
            this.dtarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtarih.FieldName = "dtarih";
            this.dtarih.Name = "dtarih";
            this.dtarih.Visible = true;
            this.dtarih.VisibleIndex = 2;
            this.dtarih.Width = 90;
            // 
            // tc
            // 
            this.tc.Caption = "TC";
            this.tc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tc.FieldName = "tc";
            this.tc.Name = "tc";
            this.tc.Visible = true;
            this.tc.VisibleIndex = 3;
            this.tc.Width = 70;
            // 
            // anaad
            // 
            this.anaad.Caption = "ANNE ADI";
            this.anaad.FieldName = "anaad";
            this.anaad.Name = "anaad";
            this.anaad.Visible = true;
            this.anaad.VisibleIndex = 4;
            this.anaad.Width = 46;
            // 
            // babaad
            // 
            this.babaad.Caption = "BABA ADI";
            this.babaad.FieldName = "babaad";
            this.babaad.Name = "babaad";
            this.babaad.Visible = true;
            this.babaad.VisibleIndex = 5;
            this.babaad.Width = 46;
            // 
            // adres
            // 
            this.adres.Caption = "ADRES";
            this.adres.FieldName = "adres";
            this.adres.Name = "adres";
            this.adres.Visible = true;
            this.adres.VisibleIndex = 6;
            this.adres.Width = 46;
            // 
            // tel
            // 
            this.tel.Caption = "TELEFON";
            this.tel.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tel.FieldName = "tel";
            this.tel.Name = "tel";
            this.tel.Visible = true;
            this.tel.VisibleIndex = 7;
            this.tel.Width = 46;
            // 
            // mail
            // 
            this.mail.Caption = "MAİL";
            this.mail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.mail.FieldName = "mail";
            this.mail.Name = "mail";
            this.mail.Visible = true;
            this.mail.VisibleIndex = 8;
            this.mail.Width = 46;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Caption = "CİNSİYET";
            this.cinsiyet.ColumnEdit = this.repositoryItemImageComboBox1;
            this.cinsiyet.FieldName = "cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Visible = true;
            this.cinsiyet.VisibleIndex = 9;
            this.cinsiyet.Width = 46;
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
            // ımageCollection1
            // 
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "female.png");
            this.ımageCollection1.Images.SetKeyName(1, "male.png");
            // 
            // okul
            // 
            this.okul.Caption = "OKUL";
            this.okul.FieldName = "okul";
            this.okul.Name = "okul";
            this.okul.Visible = true;
            this.okul.VisibleIndex = 10;
            this.okul.Width = 46;
            // 
            // sinif
            // 
            this.sinif.Caption = "SINIF";
            this.sinif.FieldName = "sinif";
            this.sinif.Name = "sinif";
            this.sinif.Visible = true;
            this.sinif.VisibleIndex = 11;
            this.sinif.Width = 46;
            // 
            // donem
            // 
            this.donem.Caption = "DÖNEM";
            this.donem.FieldName = "donem";
            this.donem.Name = "donem";
            this.donem.Visible = true;
            this.donem.VisibleIndex = 12;
            this.donem.Width = 46;
            // 
            // aciklama
            // 
            this.aciklama.Caption = "AÇIKLAMA";
            this.aciklama.FieldName = "aciklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.Visible = true;
            this.aciklama.VisibleIndex = 13;
            this.aciklama.Width = 73;
            // 
            // frmStudentDefine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1194, 596);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "frmStudentDefine";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "ÖĞRENCİ TANIMLARI";
            this.Load += new System.EventHandler(this.frmStudentDefine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn ad;
        private DevExpress.XtraGrid.Columns.GridColumn soyad;
        private DevExpress.XtraGrid.Columns.GridColumn dtarih;
        private DevExpress.XtraGrid.Columns.GridColumn tc;
        private DevExpress.XtraGrid.Columns.GridColumn anaad;
        private DevExpress.XtraGrid.Columns.GridColumn babaad;
        private DevExpress.XtraGrid.Columns.GridColumn adres;
        private DevExpress.XtraGrid.Columns.GridColumn tel;
        private DevExpress.XtraGrid.Columns.GridColumn mail;
        private DevExpress.XtraGrid.Columns.GridColumn cinsiyet;
        private DevExpress.XtraGrid.Columns.GridColumn okul;
        private DevExpress.XtraGrid.Columns.GridColumn sinif;
        private DevExpress.XtraGrid.Columns.GridColumn donem;
        private DevExpress.XtraGrid.Columns.GridColumn aciklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection ımageCollection1;
    }
}
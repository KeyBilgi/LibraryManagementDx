namespace LibraryManagement_Beta
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnKitapTanımlar = new DevExpress.XtraBars.BarButtonItem();
            this.mnOgrenciTanımlar = new DevExpress.XtraBars.BarButtonItem();
            this.mnKitapHar = new DevExpress.XtraBars.BarButtonItem();
            this.mnStudentRep = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnRaporlar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.mnLocationDefine = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mnKitapTanımlar,
            this.mnOgrenciTanımlar,
            this.mnKitapHar,
            this.mnStudentRep,
            this.barButtonItem1,
            this.mnLocationDefine,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.mnRaporlar});
            this.ribbonControl1.Size = new System.Drawing.Size(796, 146);
            // 
            // mnKitapTanımlar
            // 
            this.mnKitapTanımlar.Caption = "Kitap Tanımları";
            this.mnKitapTanımlar.Id = 5;
            this.mnKitapTanımlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnKitapTanımlar.ImageOptions.Image")));
            this.mnKitapTanımlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnKitapTanımlar.ImageOptions.LargeImage")));
            this.mnKitapTanımlar.Name = "mnKitapTanımlar";
            this.mnKitapTanımlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnKitapTanımlar_ItemClick);
            // 
            // mnOgrenciTanımlar
            // 
            this.mnOgrenciTanımlar.Caption = "Öğrenci Tanımları";
            this.mnOgrenciTanımlar.Id = 6;
            this.mnOgrenciTanımlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnOgrenciTanımlar.ImageOptions.LargeImage")));
            this.mnOgrenciTanımlar.Name = "mnOgrenciTanımlar";
            this.mnOgrenciTanımlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnOgrenciTanımlar_ItemClick);
            // 
            // mnKitapHar
            // 
            this.mnKitapHar.Caption = "Kitap Ver";
            this.mnKitapHar.Id = 7;
            this.mnKitapHar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnKitapHar.ImageOptions.LargeImage")));
            this.mnKitapHar.Name = "mnKitapHar";
            this.mnKitapHar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnKitapHar_ItemClick);
            // 
            // mnStudentRep
            // 
            this.mnStudentRep.Caption = "Kitap Durum Raporu";
            this.mnStudentRep.Id = 8;
            this.mnStudentRep.Name = "mnStudentRep";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kitap Al";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tanımlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnKitapTanımlar, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnOgrenciTanımlar, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnLocationDefine, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tanımlar";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hareketler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mnKitapHar, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hareketler";
            // 
            // mnRaporlar
            // 
            this.mnRaporlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.mnRaporlar.Name = "mnRaporlar";
            this.mnRaporlar.Text = "Raporlar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.mnStudentRep);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Raporlar";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // mnLocationDefine
            // 
            this.mnLocationDefine.Caption = "Lokasyon Tanımları";
            this.mnLocationDefine.Id = 10;
            this.mnLocationDefine.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnLocationDefine.ImageOptions.LargeImage")));
            this.mnLocationDefine.Name = "mnLocationDefine";
            this.mnLocationDefine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnLocationDefine_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Öğrenci Durum Raporu";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::LibraryManagement_Beta.Properties.Resources._363;
            this.ClientSize = new System.Drawing.Size(796, 509);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Versiyon~0.0.1 {Kitap Otomasyonu}                  MEHMET AKNAR";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem mnKitapTanımlar;
        private DevExpress.XtraBars.BarButtonItem mnOgrenciTanımlar;
        private DevExpress.XtraBars.BarButtonItem mnKitapHar;
        private DevExpress.XtraBars.BarButtonItem mnStudentRep;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnRaporlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem mnLocationDefine;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}
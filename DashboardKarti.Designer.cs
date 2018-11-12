namespace BarduckCRM
{
    partial class DashboardKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardKarti));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydetKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnTasarim = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnKaydet,
            this.btnKaydetKapat,
            this.btnDuzenle,
            this.btnTemizle,
            this.btnSil,
            this.btnTasarim});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(598, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 1;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.LargeImage")));
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydet_ItemClick);
            // 
            // btnKaydetKapat
            // 
            this.btnKaydetKapat.Caption = "Kaydet ve Kapat";
            this.btnKaydetKapat.Id = 2;
            this.btnKaydetKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydetKapat.ImageOptions.Image")));
            this.btnKaydetKapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKaydetKapat.ImageOptions.LargeImage")));
            this.btnKaydetKapat.Name = "btnKaydetKapat";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Caption = "Düzenle";
            this.btnDuzenle.Id = 4;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.LargeImage")));
            this.btnDuzenle.Name = "btnDuzenle";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Caption = "Temizle";
            this.btnTemizle.Id = 5;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.LargeImage")));
            this.btnTemizle.Name = "btnTemizle";
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 6;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.Name = "btnSil";
            // 
            // btnTasarim
            // 
            this.btnTasarim.Caption = "Tasarım";
            this.btnTasarim.Id = 7;
            this.btnTasarim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTasarim.ImageOptions.Image")));
            this.btnTasarim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTasarim.ImageOptions.LargeImage")));
            this.btnTasarim.Name = "btnTasarim";
            this.btnTasarim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTasarim_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dashboard Kartı";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydetKapat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Kaydet";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDuzenle);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTemizle);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Düzenle";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Sil";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTasarim);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "İşlemler";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 323);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(598, 31);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 22);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(121, 157);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(323, 20);
            this.txtAdi.TabIndex = 24;
            // 
            // DashboardKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 354);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DashboardKarti";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Dashboard Kartı";
            this.Load += new System.EventHandler(this.DashboardKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnKaydetKapat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarButtonItem btnTemizle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTasarim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAdi;
    }
}
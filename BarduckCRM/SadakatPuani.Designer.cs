namespace BarduckCRM
{
    partial class SadakatPuani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SadakatPuani));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydetVeKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPuanEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnPuanCikart = new DevExpress.XtraBars.BarButtonItem();
            this.btnBilgi = new DevExpress.XtraBars.BarButtonItem();
            this.btnKapat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.sSadakatPuaniHesaplaResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIslemYapilacakPuan = new DevExpress.XtraEditors.SpinEdit();
            this.memoAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTarih = new DevExpress.XtraEditors.DateEdit();
            this.cmbPuanKategorisi = new DevExpress.XtraEditors.LookUpEdit();
            this.sTipResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.lblAdiSoyadi = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSadakatPuaniHesaplaResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslemYapilacakPuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuanKategorisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTipResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnKaydet,
            this.btnKaydetVeKapat,
            this.btnPuanEkle,
            this.btnPuanCikart,
            this.btnBilgi,
            this.btnKapat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(384, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Glyph")));
            this.btnKaydet.Id = 1;
            this.btnKaydet.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKaydet.LargeGlyph")));
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydet_ItemClick);
            // 
            // btnKaydetVeKapat
            // 
            this.btnKaydetVeKapat.Caption = "Kaydet ve Kapat";
            this.btnKaydetVeKapat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKaydetVeKapat.Glyph")));
            this.btnKaydetVeKapat.Id = 2;
            this.btnKaydetVeKapat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKaydetVeKapat.LargeGlyph")));
            this.btnKaydetVeKapat.Name = "btnKaydetVeKapat";
            this.btnKaydetVeKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydetVeKapat_ItemClick);
            // 
            // btnPuanEkle
            // 
            this.btnPuanEkle.Caption = "Puan Ekle";
            this.btnPuanEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPuanEkle.Glyph")));
            this.btnPuanEkle.Id = 3;
            this.btnPuanEkle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPuanEkle.LargeGlyph")));
            this.btnPuanEkle.Name = "btnPuanEkle";
            this.btnPuanEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPuanEkle_ItemClick);
            // 
            // btnPuanCikart
            // 
            this.btnPuanCikart.Caption = "Puan Çıkart";
            this.btnPuanCikart.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPuanCikart.Glyph")));
            this.btnPuanCikart.Id = 4;
            this.btnPuanCikart.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPuanCikart.LargeGlyph")));
            this.btnPuanCikart.Name = "btnPuanCikart";
            this.btnPuanCikart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPuanCikart_ItemClick);
            // 
            // btnBilgi
            // 
            this.btnBilgi.Caption = "Bilgi";
            this.btnBilgi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBilgi.Glyph")));
            this.btnBilgi.Id = 5;
            this.btnBilgi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBilgi.LargeGlyph")));
            this.btnBilgi.Name = "btnBilgi";
            // 
            // btnKapat
            // 
            this.btnKapat.Caption = "Kapat";
            this.btnKapat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKapat.Glyph")));
            this.btnKapat.Id = 6;
            this.btnKapat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKapat.LargeGlyph")));
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKapat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sadakat Puanı";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydetVeKapat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Kayıt İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPuanEkle);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPuanCikart);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Puan İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBilgi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKapat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Barduck CRM";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 537);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(384, 31);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(22, 358);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 22);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "İşlem Yapılacak Puan";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent13";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style11;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // sSadakatPuaniHesaplaResultBindingSource
            // 
            this.sSadakatPuaniHesaplaResultBindingSource.DataSource = typeof(BarduckCRM.S_SadakatPuaniHesapla_Result);
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(175, 210);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 22);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Mevcut Puan";
            // 
            // txtIslemYapilacakPuan
            // 
            this.txtIslemYapilacakPuan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIslemYapilacakPuan.Location = new System.Drawing.Point(131, 359);
            this.txtIslemYapilacakPuan.Name = "txtIslemYapilacakPuan";
            this.txtIslemYapilacakPuan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIslemYapilacakPuan.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtIslemYapilacakPuan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtIslemYapilacakPuan.Size = new System.Drawing.Size(232, 20);
            this.txtIslemYapilacakPuan.TabIndex = 24;
            // 
            // memoAciklama
            // 
            this.memoAciklama.Location = new System.Drawing.Point(131, 438);
            this.memoAciklama.MenuManager = this.ribbon;
            this.memoAciklama.Name = "memoAciklama";
            this.memoAciklama.Size = new System.Drawing.Size(232, 82);
            this.memoAciklama.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(22, 439);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 22);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Açıklama";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(22, 384);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 22);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "İşlem Tarihi";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(22, 410);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 22);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "Puan Kategorisi";
            // 
            // cmbTarih
            // 
            this.cmbTarih.EditValue = null;
            this.cmbTarih.Location = new System.Drawing.Point(131, 385);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTarih.Properties.DisplayFormat.FormatString = "";
            this.cmbTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbTarih.Properties.EditFormat.FormatString = "";
            this.cmbTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbTarih.Properties.Mask.EditMask = "";
            this.cmbTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cmbTarih.Size = new System.Drawing.Size(232, 20);
            this.cmbTarih.TabIndex = 40;
            // 
            // cmbPuanKategorisi
            // 
            this.cmbPuanKategorisi.Location = new System.Drawing.Point(131, 411);
            this.cmbPuanKategorisi.Name = "cmbPuanKategorisi";
            this.cmbPuanKategorisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuanKategorisi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ad", "Ad", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbPuanKategorisi.Properties.DataSource = this.sTipResultBindingSource;
            this.cmbPuanKategorisi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbPuanKategorisi.Properties.DisplayMember = "Ad";
            this.cmbPuanKategorisi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cmbPuanKategorisi.Properties.NullText = "";
            this.cmbPuanKategorisi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPuanKategorisi.Properties.ValueMember = "ID";
            this.cmbPuanKategorisi.Size = new System.Drawing.Size(232, 20);
            this.cmbPuanKategorisi.TabIndex = 41;
            // 
            // sTipResultBindingSource
            // 
            this.sTipResultBindingSource.DataSource = typeof(BarduckCRM.S_Tip_Result);
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(175, 238);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(173, 73);
            this.gaugeControl1.TabIndex = 43;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C8C8C8");
            this.digitalGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent2});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 161, 61);
            this.digitalGauge1.DigitCount = 5;
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Text = "00,000";
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(259.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent13";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style11;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblAdiSoyadi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(22, 164);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(341, 25);
            this.lblAdiSoyadi.TabIndex = 45;
            this.lblAdiSoyadi.Text = "adisoyadi";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::BarduckCRM.Properties.Resources.newuser;
            this.pictureEdit1.Location = new System.Drawing.Point(22, 205);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(130, 130);
            this.pictureEdit1.TabIndex = 44;
            // 
            // SadakatPuani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 568);
            this.Controls.Add(this.lblAdiSoyadi);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.memoAciklama);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.txtIslemYapilacakPuan);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.cmbPuanKategorisi);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SadakatPuani";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sadakat Puanı";
            this.Load += new System.EventHandler(this.SadakatPuani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSadakatPuaniHesaplaResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslemYapilacakPuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuanKategorisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTipResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnKaydetVeKapat;
        private DevExpress.XtraBars.BarButtonItem btnPuanEkle;
        private DevExpress.XtraBars.BarButtonItem btnPuanCikart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit txtIslemYapilacakPuan;
        private DevExpress.XtraEditors.MemoEdit memoAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem btnBilgi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKapat;
        private System.Windows.Forms.BindingSource sSadakatPuaniHesaplaResultBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit cmbTarih;
        private DevExpress.XtraEditors.LookUpEdit cmbPuanKategorisi;
        private System.Windows.Forms.BindingSource sTipResultBindingSource;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private DevExpress.XtraEditors.LabelControl lblAdiSoyadi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
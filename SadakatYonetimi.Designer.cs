namespace BarduckCRM
{
    partial class SadakatYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SadakatYonetimi));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBaglantiEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnPuan = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaglantiDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnTopluPuanIslemleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grdBaglanti = new DevExpress.XtraGrid.GridControl();
            this.sBaglantiResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvBaglanti = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureOnek = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeslek_TipID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMeslek = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.colUlke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageOnek = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBaglanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaglantiResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaglanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnBaglantiEkle,
            this.btnPuan,
            this.btnBaglantiDuzenle,
            this.btnTopluPuanIslemleri});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1034, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnBaglantiEkle
            // 
            this.btnBaglantiEkle.Caption = "Bağlantı Ekle";
            this.btnBaglantiEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaglantiEkle.Glyph")));
            this.btnBaglantiEkle.Id = 1;
            this.btnBaglantiEkle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBaglantiEkle.LargeGlyph")));
            this.btnBaglantiEkle.Name = "btnBaglantiEkle";
            // 
            // btnPuan
            // 
            this.btnPuan.Caption = "Puan İşlemleri";
            this.btnPuan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPuan.Glyph")));
            this.btnPuan.Id = 2;
            this.btnPuan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPuan.LargeGlyph")));
            this.btnPuan.Name = "btnPuan";
            this.btnPuan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPuan_ItemClick);
            // 
            // btnBaglantiDuzenle
            // 
            this.btnBaglantiDuzenle.Caption = "Bağlantı Düzenle";
            this.btnBaglantiDuzenle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaglantiDuzenle.Glyph")));
            this.btnBaglantiDuzenle.Id = 4;
            this.btnBaglantiDuzenle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBaglantiDuzenle.LargeGlyph")));
            this.btnBaglantiDuzenle.Name = "btnBaglantiDuzenle";
            // 
            // btnTopluPuanIslemleri
            // 
            this.btnTopluPuanIslemleri.Caption = "Toplu Puan İşlemleri";
            this.btnTopluPuanIslemleri.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTopluPuanIslemleri.Glyph")));
            this.btnTopluPuanIslemleri.Id = 5;
            this.btnTopluPuanIslemleri.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTopluPuanIslemleri.LargeGlyph")));
            this.btnTopluPuanIslemleri.Name = "btnTopluPuanIslemleri";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sadakat Yönetimi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBaglantiEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBaglantiDuzenle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Bağlantı İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPuan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTopluPuanIslemleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Sadakat İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 603);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1034, 31);
            // 
            // grdBaglanti
            // 
            this.grdBaglanti.DataSource = this.sBaglantiResultBindingSource;
            this.grdBaglanti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBaglanti.Location = new System.Drawing.Point(0, 143);
            this.grdBaglanti.MainView = this.gvBaglanti;
            this.grdBaglanti.Name = "grdBaglanti";
            this.grdBaglanti.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.imageOnek,
            this.repositoryItemPictureEdit1,
            this.pictureOnek,
            this.cmbMeslek,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemProgressBar1});
            this.grdBaglanti.Size = new System.Drawing.Size(1034, 460);
            this.grdBaglanti.TabIndex = 2;
            this.grdBaglanti.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBaglanti});
            // 
            // sBaglantiResultBindingSource
            // 
            this.sBaglantiResultBindingSource.DataSource = typeof(BarduckCRM.S_Baglanti_Result);
            // 
            // gvBaglanti
            // 
            this.gvBaglanti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colOnek,
            this.colAdiSoyadi,
            this.colMeslek_TipID2,
            this.colTarih,
            this.colPuan,
            this.colUlke,
            this.colSehir,
            this.colAdres,
            this.colCepTel,
            this.colEvTel,
            this.colIsTel,
            this.colEmail,
            this.colAktif,
            this.colCinsiyet,
            this.colFirmaID});
            this.gvBaglanti.GridControl = this.grdBaglanti;
            this.gvBaglanti.Name = "gvBaglanti";
            this.gvBaglanti.OptionsBehavior.Editable = false;
            this.gvBaglanti.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colOnek
            // 
            this.colOnek.ColumnEdit = this.pictureOnek;
            this.colOnek.FieldName = "OnekResim";
            this.colOnek.Name = "colOnek";
            this.colOnek.OptionsColumn.ShowCaption = false;
            this.colOnek.Visible = true;
            this.colOnek.VisibleIndex = 0;
            this.colOnek.Width = 30;
            // 
            // pictureOnek
            // 
            this.pictureOnek.Name = "pictureOnek";
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.Caption = "ADI SOYADI";
            this.colAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.Visible = true;
            this.colAdiSoyadi.VisibleIndex = 1;
            this.colAdiSoyadi.Width = 200;
            // 
            // colMeslek_TipID2
            // 
            this.colMeslek_TipID2.Caption = "MESLEK";
            this.colMeslek_TipID2.ColumnEdit = this.cmbMeslek;
            this.colMeslek_TipID2.FieldName = "Meslek_TipID2";
            this.colMeslek_TipID2.Name = "colMeslek_TipID2";
            this.colMeslek_TipID2.Visible = true;
            this.colMeslek_TipID2.VisibleIndex = 2;
            this.colMeslek_TipID2.Width = 150;
            // 
            // cmbMeslek
            // 
            this.cmbMeslek.AutoHeight = false;
            this.cmbMeslek.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMeslek.DisplayMember = "Ad";
            this.cmbMeslek.Name = "cmbMeslek";
            this.cmbMeslek.ShowFooter = false;
            this.cmbMeslek.ShowHeader = false;
            this.cmbMeslek.ValueMember = "ID";
            // 
            // colTarih
            // 
            this.colTarih.Caption = "TARİH";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "PUAN";
            this.colPuan.ColumnEdit = this.repositoryItemProgressBar1;
            this.colPuan.FieldName = "Puan";
            this.colPuan.Name = "colPuan";
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 4;
            this.colPuan.Width = 150;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // colUlke
            // 
            this.colUlke.Caption = "ÜLKE";
            this.colUlke.FieldName = "Ulke";
            this.colUlke.Name = "colUlke";
            this.colUlke.Visible = true;
            this.colUlke.VisibleIndex = 5;
            // 
            // colSehir
            // 
            this.colSehir.Caption = "ŞEHİR";
            this.colSehir.FieldName = "Sehir";
            this.colSehir.Name = "colSehir";
            this.colSehir.Visible = true;
            this.colSehir.VisibleIndex = 6;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "ADRES";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 7;
            this.colAdres.Width = 300;
            // 
            // colCepTel
            // 
            this.colCepTel.Caption = "CEP TELEFONU";
            this.colCepTel.FieldName = "CepTel";
            this.colCepTel.Name = "colCepTel";
            this.colCepTel.Visible = true;
            this.colCepTel.VisibleIndex = 8;
            this.colCepTel.Width = 150;
            // 
            // colEvTel
            // 
            this.colEvTel.Caption = "EV TELEFONU";
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.Visible = true;
            this.colEvTel.VisibleIndex = 11;
            this.colEvTel.Width = 150;
            // 
            // colIsTel
            // 
            this.colIsTel.Caption = "İŞ TELEFONU";
            this.colIsTel.FieldName = "IsTel";
            this.colIsTel.Name = "colIsTel";
            this.colIsTel.Visible = true;
            this.colIsTel.VisibleIndex = 10;
            this.colIsTel.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-POSTA ADRESİ";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            this.colEmail.Width = 150;
            // 
            // colAktif
            // 
            this.colAktif.FieldName = "Aktif";
            this.colAktif.Name = "colAktif";
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            // 
            // colFirmaID
            // 
            this.colFirmaID.FieldName = "FirmaID";
            this.colFirmaID.Name = "colFirmaID";
            // 
            // imageOnek
            // 
            this.imageOnek.AutoHeight = false;
            this.imageOnek.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageOnek.Name = "imageOnek";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // SadakatYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.grdBaglanti);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SadakatYonetimi";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sadakat Yönetimi";
            this.Load += new System.EventHandler(this.SadakatYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBaglanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaglantiResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaglanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBaglantiEkle;
        private DevExpress.XtraBars.BarButtonItem btnPuan;
        private DevExpress.XtraBars.BarButtonItem btnBaglantiDuzenle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl grdBaglanti;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBaglanti;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pictureOnek;
        private DevExpress.XtraGrid.Columns.GridColumn colAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colMeslek_TipID2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbMeslek;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPuan;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colUlke;
        private DevExpress.XtraGrid.Columns.GridColumn colSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEvTel;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsiyet;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaID;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit imageOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private System.Windows.Forms.BindingSource sBaglantiResultBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnTopluPuanIslemleri;
    }
}
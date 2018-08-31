namespace BarduckCRM
{
    partial class Baglanti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baglanti));
            this.grdBaglanti = new DevExpress.XtraGrid.GridControl();
            this.sBaglantiResultBindingSource = new System.Windows.Forms.BindingSource();
            this.gvBaglanti = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureOnek = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btnGridAyar_KolonEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_Gruplama = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_Altbilgi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_Gosterge = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_Filtre = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_SutunCizgileri = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_SatirCizgileri = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_KolonlariHizala = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_KolonFiltreTipi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_GruplamalariAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_GruplamalariKapat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_SayfaOnizleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_DisaAktar = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridAyar_GridAyarKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.grdBaglanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaglantiResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaglanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
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
            this.grdBaglanti.Size = new System.Drawing.Size(939, 434);
            this.grdBaglanti.TabIndex = 1;
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
            this.colFirmaAdi,
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
            this.gvBaglanti.DoubleClick += new System.EventHandler(this.gvBaglanti_DoubleClick);
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
            this.colAdiSoyadi.Width = 150;
            // 
            // colFirmaAdi
            // 
            this.colFirmaAdi.Caption = "FİRMA ADI";
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.VisibleIndex = 2;
            this.colFirmaAdi.Width = 150;
            // 
            // colMeslek_TipID2
            // 
            this.colMeslek_TipID2.Caption = "MESLEK";
            this.colMeslek_TipID2.ColumnEdit = this.cmbMeslek;
            this.colMeslek_TipID2.FieldName = "Meslek_TipID2";
            this.colMeslek_TipID2.Name = "colMeslek_TipID2";
            this.colMeslek_TipID2.Visible = true;
            this.colMeslek_TipID2.VisibleIndex = 3;
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
            this.colTarih.VisibleIndex = 4;
            this.colTarih.Width = 150;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "PUAN";
            this.colPuan.ColumnEdit = this.repositoryItemProgressBar1;
            this.colPuan.FieldName = "Puan";
            this.colPuan.Name = "colPuan";
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 5;
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
            this.colUlke.VisibleIndex = 6;
            this.colUlke.Width = 150;
            // 
            // colSehir
            // 
            this.colSehir.Caption = "ŞEHİR";
            this.colSehir.FieldName = "Sehir";
            this.colSehir.Name = "colSehir";
            this.colSehir.Visible = true;
            this.colSehir.VisibleIndex = 7;
            this.colSehir.Width = 150;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "ADRES";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 8;
            this.colAdres.Width = 300;
            // 
            // colCepTel
            // 
            this.colCepTel.Caption = "CEP TELEFONU";
            this.colCepTel.FieldName = "CepTel";
            this.colCepTel.Name = "colCepTel";
            this.colCepTel.Visible = true;
            this.colCepTel.VisibleIndex = 9;
            this.colCepTel.Width = 150;
            // 
            // colEvTel
            // 
            this.colEvTel.Caption = "EV TELEFONU";
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.Visible = true;
            this.colEvTel.VisibleIndex = 12;
            this.colEvTel.Width = 150;
            // 
            // colIsTel
            // 
            this.colIsTel.Caption = "İŞ TELEFONU";
            this.colIsTel.FieldName = "IsTel";
            this.colIsTel.Name = "colIsTel";
            this.colIsTel.Visible = true;
            this.colIsTel.VisibleIndex = 11;
            this.colIsTel.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-POSTA ADRESİ";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 10;
            this.colEmail.Width = 150;
            // 
            // colAktif
            // 
            this.colAktif.FieldName = "Aktif";
            this.colAktif.Name = "colAktif";
            this.colAktif.Width = 150;
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.FieldName = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            this.colCinsiyet.Width = 150;
            // 
            // colFirmaID
            // 
            this.colFirmaID.FieldName = "FirmaID";
            this.colFirmaID.Name = "colFirmaID";
            this.colFirmaID.Width = 150;
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
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnEkle,
            this.btnDuzenle,
            this.btnSil,
            this.barToggleSwitchItem1,
            this.btnGridAyar_KolonEkle,
            this.btnGridAyar_Gruplama,
            this.btnGridAyar_Altbilgi,
            this.btnGridAyar_Gosterge,
            this.btnGridAyar_Filtre,
            this.btnGridAyar_SutunCizgileri,
            this.btnGridAyar_SatirCizgileri,
            this.btnGridAyar_KolonlariHizala,
            this.btnGridAyar_KolonFiltreTipi,
            this.btnGridAyar_GruplamalariAc,
            this.btnGridAyar_GruplamalariKapat,
            this.btnGridAyar_SayfaOnizleme,
            this.btnGridAyar_DisaAktar,
            this.btnGridAyar_GridAyarKaydet});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(939, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Caption = "Ekle";
            this.btnEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEkle.Glyph")));
            this.btnEkle.Id = 1;
            this.btnEkle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEkle.LargeGlyph")));
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEkle_ItemClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Caption = "Düzenle";
            this.btnDuzenle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Glyph")));
            this.btnDuzenle.Id = 2;
            this.btnDuzenle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.LargeGlyph")));
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuzenle_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSil.Glyph")));
            this.btnSil.Id = 3;
            this.btnSil.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSil.LargeGlyph")));
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "Aktif";
            this.barToggleSwitchItem1.Id = 1;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1"; 
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Bağlantı";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDuzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Temel İşlemler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barToggleSwitchItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Bağlantı Detayları";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 577);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(939, 31);
            // 
            // Baglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 608);
            this.Controls.Add(this.grdBaglanti);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baglanti";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Bağlantı";
            this.Load += new System.EventHandler(this.Baglanti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBaglanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaglantiResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaglanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnEkle;
        private DevExpress.XtraBars.BarButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_KolonEkle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_Gruplama;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_Altbilgi;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_Gosterge;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_Filtre;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_SutunCizgileri;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_SatirCizgileri;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_KolonlariHizala;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_KolonFiltreTipi;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_GruplamalariAc;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_GruplamalariKapat;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_SayfaOnizleme;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_DisaAktar;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_GridAyarKaydet;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaAdi;
    }
}
namespace BarduckCRM
{
    partial class PersonelTakimlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelTakimlari));
            this.grdTakim = new DevExpress.XtraGrid.GridControl();
            this.gvTakim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageOnek = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.pictureOnek = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.cmbMeslek = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.sPersonelResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
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
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.sTakimResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakimKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTakimAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOlusturanKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOlusturanKullaniciTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirenKullaniciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistirenKullaniciTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTakim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTakim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPersonelResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTakimResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTakim
            // 
            this.grdTakim.DataSource = this.sTakimResultBindingSource;
            this.grdTakim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTakim.Location = new System.Drawing.Point(0, 143);
            this.grdTakim.MainView = this.gvTakim;
            this.grdTakim.Name = "grdTakim";
            this.grdTakim.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.imageOnek,
            this.repositoryItemPictureEdit1,
            this.pictureOnek,
            this.cmbMeslek,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemProgressBar1});
            this.grdTakim.Size = new System.Drawing.Size(1067, 396);
            this.grdTakim.TabIndex = 5;
            this.grdTakim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTakim});
            // 
            // gvTakim
            // 
            this.gvTakim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTakimKodu,
            this.colTakimAdi,
            this.colTarih,
            this.colAktif,
            this.colSil,
            this.colOlusturanKullaniciID,
            this.colOlusturanKullaniciTarih,
            this.colDegistirenKullaniciID,
            this.colDegistirenKullaniciTarih});
            this.gvTakim.GridControl = this.grdTakim;
            this.gvTakim.Name = "gvTakim";
            this.gvTakim.OptionsBehavior.Editable = false;
            this.gvTakim.OptionsView.ColumnAutoWidth = false;
            this.gvTakim.OptionsView.ShowFooter = true;
            this.gvTakim.OptionsView.ShowGroupPanel = false;
            this.gvTakim.DoubleClick += new System.EventHandler(this.gvTakim_DoubleClick);
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
            // pictureOnek
            // 
            this.pictureOnek.Name = "pictureOnek";
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
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // sPersonelResultBindingSource
            // 
            this.sPersonelResultBindingSource.DataSource = typeof(BarduckCRM.S_Personel_Result);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ofis";
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
            this.ribbonControl1.Size = new System.Drawing.Size(1067, 143);
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
            // btnGridAyar_KolonEkle
            // 
            this.btnGridAyar_KolonEkle.Caption = "Kolon Ekle";
            this.btnGridAyar_KolonEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_KolonEkle.Glyph")));
            this.btnGridAyar_KolonEkle.Id = 4;
            this.btnGridAyar_KolonEkle.Name = "btnGridAyar_KolonEkle";
            // 
            // btnGridAyar_Gruplama
            // 
            this.btnGridAyar_Gruplama.Caption = "Gruplama ";
            this.btnGridAyar_Gruplama.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_Gruplama.Glyph")));
            this.btnGridAyar_Gruplama.Id = 5;
            this.btnGridAyar_Gruplama.Name = "btnGridAyar_Gruplama";
            // 
            // btnGridAyar_Altbilgi
            // 
            this.btnGridAyar_Altbilgi.Caption = "Altbilgi";
            this.btnGridAyar_Altbilgi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_Altbilgi.Glyph")));
            this.btnGridAyar_Altbilgi.Id = 6;
            this.btnGridAyar_Altbilgi.Name = "btnGridAyar_Altbilgi";
            // 
            // btnGridAyar_Gosterge
            // 
            this.btnGridAyar_Gosterge.Caption = "Gösterge";
            this.btnGridAyar_Gosterge.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_Gosterge.Glyph")));
            this.btnGridAyar_Gosterge.Id = 7;
            this.btnGridAyar_Gosterge.Name = "btnGridAyar_Gosterge";
            // 
            // btnGridAyar_Filtre
            // 
            this.btnGridAyar_Filtre.Caption = "Filtre";
            this.btnGridAyar_Filtre.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_Filtre.Glyph")));
            this.btnGridAyar_Filtre.Id = 8;
            this.btnGridAyar_Filtre.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_Filtre.LargeGlyph")));
            this.btnGridAyar_Filtre.Name = "btnGridAyar_Filtre";
            // 
            // btnGridAyar_SutunCizgileri
            // 
            this.btnGridAyar_SutunCizgileri.Caption = "Sütun Cizgileri";
            this.btnGridAyar_SutunCizgileri.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_SutunCizgileri.Glyph")));
            this.btnGridAyar_SutunCizgileri.Id = 9;
            this.btnGridAyar_SutunCizgileri.Name = "btnGridAyar_SutunCizgileri";
            // 
            // btnGridAyar_SatirCizgileri
            // 
            this.btnGridAyar_SatirCizgileri.Caption = "Satır Cizgileri";
            this.btnGridAyar_SatirCizgileri.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_SatirCizgileri.Glyph")));
            this.btnGridAyar_SatirCizgileri.Id = 10;
            this.btnGridAyar_SatirCizgileri.Name = "btnGridAyar_SatirCizgileri";
            // 
            // btnGridAyar_KolonlariHizala
            // 
            this.btnGridAyar_KolonlariHizala.Caption = "Kolonları Hizala";
            this.btnGridAyar_KolonlariHizala.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_KolonlariHizala.Glyph")));
            this.btnGridAyar_KolonlariHizala.Id = 11;
            this.btnGridAyar_KolonlariHizala.Name = "btnGridAyar_KolonlariHizala";
            // 
            // btnGridAyar_KolonFiltreTipi
            // 
            this.btnGridAyar_KolonFiltreTipi.Caption = "Kolon Filtre Tipi";
            this.btnGridAyar_KolonFiltreTipi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_KolonFiltreTipi.Glyph")));
            this.btnGridAyar_KolonFiltreTipi.Id = 12;
            this.btnGridAyar_KolonFiltreTipi.Name = "btnGridAyar_KolonFiltreTipi";
            // 
            // btnGridAyar_GruplamalariAc
            // 
            this.btnGridAyar_GruplamalariAc.Caption = "Gruplamaları Aç";
            this.btnGridAyar_GruplamalariAc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_GruplamalariAc.Glyph")));
            this.btnGridAyar_GruplamalariAc.Id = 13;
            this.btnGridAyar_GruplamalariAc.Name = "btnGridAyar_GruplamalariAc";
            // 
            // btnGridAyar_GruplamalariKapat
            // 
            this.btnGridAyar_GruplamalariKapat.Caption = "Gruplamaları Kapat";
            this.btnGridAyar_GruplamalariKapat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_GruplamalariKapat.Glyph")));
            this.btnGridAyar_GruplamalariKapat.Id = 14;
            this.btnGridAyar_GruplamalariKapat.Name = "btnGridAyar_GruplamalariKapat";
            // 
            // btnGridAyar_SayfaOnizleme
            // 
            this.btnGridAyar_SayfaOnizleme.Caption = "Sayfa Önizleme";
            this.btnGridAyar_SayfaOnizleme.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_SayfaOnizleme.Glyph")));
            this.btnGridAyar_SayfaOnizleme.Id = 15;
            this.btnGridAyar_SayfaOnizleme.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_SayfaOnizleme.LargeGlyph")));
            this.btnGridAyar_SayfaOnizleme.Name = "btnGridAyar_SayfaOnizleme";
            // 
            // btnGridAyar_DisaAktar
            // 
            this.btnGridAyar_DisaAktar.Caption = "Dışa Aktar";
            this.btnGridAyar_DisaAktar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_DisaAktar.Glyph")));
            this.btnGridAyar_DisaAktar.Id = 16;
            this.btnGridAyar_DisaAktar.Name = "btnGridAyar_DisaAktar";
            // 
            // btnGridAyar_GridAyarKaydet
            // 
            this.btnGridAyar_GridAyarKaydet.Caption = "Grid Ayar Kaydet";
            this.btnGridAyar_GridAyarKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAyar_GridAyarKaydet.Glyph")));
            this.btnGridAyar_GridAyarKaydet.Id = 17;
            this.btnGridAyar_GridAyarKaydet.Name = "btnGridAyar_GridAyarKaydet";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Personel Takımları";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDuzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Temel İşlemler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barToggleSwitchItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Bağlantı Detayları";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_Gruplama);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_Gosterge);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_Altbilgi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_Filtre);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_KolonEkle);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_SutunCizgileri);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_SatirCizgileri);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_KolonlariHizala);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_GruplamalariAc);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_GruplamalariKapat);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_SayfaOnizleme);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_KolonFiltreTipi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_DisaAktar);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGridAyar_GridAyarKaydet);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Grid Ayarlar";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 539);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1067, 31);
            // 
            // sTakimResultBindingSource
            // 
            this.sTakimResultBindingSource.DataSource = typeof(BarduckCRM.S_Takim_Result);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTakimKodu
            // 
            this.colTakimKodu.FieldName = "TakimKodu";
            this.colTakimKodu.Name = "colTakimKodu";
            this.colTakimKodu.Visible = true;
            this.colTakimKodu.VisibleIndex = 1;
            // 
            // colTakimAdi
            // 
            this.colTakimAdi.FieldName = "TakimAdi";
            this.colTakimAdi.Name = "colTakimAdi";
            this.colTakimAdi.Visible = true;
            this.colTakimAdi.VisibleIndex = 2;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            // 
            // colAktif
            // 
            this.colAktif.FieldName = "Aktif";
            this.colAktif.Name = "colAktif";
            this.colAktif.Visible = true;
            this.colAktif.VisibleIndex = 4;
            // 
            // colSil
            // 
            this.colSil.FieldName = "Sil";
            this.colSil.Name = "colSil";
            this.colSil.Visible = true;
            this.colSil.VisibleIndex = 5;
            // 
            // colOlusturanKullaniciID
            // 
            this.colOlusturanKullaniciID.FieldName = "OlusturanKullaniciID";
            this.colOlusturanKullaniciID.Name = "colOlusturanKullaniciID";
            this.colOlusturanKullaniciID.Visible = true;
            this.colOlusturanKullaniciID.VisibleIndex = 6;
            // 
            // colOlusturanKullaniciTarih
            // 
            this.colOlusturanKullaniciTarih.FieldName = "OlusturanKullaniciTarih";
            this.colOlusturanKullaniciTarih.Name = "colOlusturanKullaniciTarih";
            this.colOlusturanKullaniciTarih.Visible = true;
            this.colOlusturanKullaniciTarih.VisibleIndex = 7;
            // 
            // colDegistirenKullaniciID
            // 
            this.colDegistirenKullaniciID.FieldName = "DegistirenKullaniciID";
            this.colDegistirenKullaniciID.Name = "colDegistirenKullaniciID";
            this.colDegistirenKullaniciID.Visible = true;
            this.colDegistirenKullaniciID.VisibleIndex = 8;
            // 
            // colDegistirenKullaniciTarih
            // 
            this.colDegistirenKullaniciTarih.FieldName = "DegistirenKullaniciTarih";
            this.colDegistirenKullaniciTarih.Name = "colDegistirenKullaniciTarih";
            this.colDegistirenKullaniciTarih.Visible = true;
            this.colDegistirenKullaniciTarih.VisibleIndex = 9;
            // 
            // PersonelTakimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.grdTakim);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelTakimlari";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Personel Takımları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelTakimlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTakim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTakim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPersonelResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTakimResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grdTakim;
        private System.Windows.Forms.BindingSource sPersonelResultBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTakim;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit imageOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pictureOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbMeslek;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnEkle;
        private DevExpress.XtraBars.BarButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem btnGridAyar_KolonEkle;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.BindingSource sTakimResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTakimKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colTakimAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraGrid.Columns.GridColumn colOlusturanKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colOlusturanKullaniciTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirenKullaniciID;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistirenKullaniciTarih;
    }
}
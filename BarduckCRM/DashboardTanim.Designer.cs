namespace BarduckCRM
{
    partial class DashboardTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardTanim));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.sEvraklarResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSonuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakTanimBasligi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklamalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDosyaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumSecID_400 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakGosterimYeriID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkilendirmeKisID_201 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageOnek = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.pictureOnek = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.cmbMeslek = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEvraklarResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnEkle,
            this.btnDuzenle,
            this.btnSil});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(922, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Dashboard Tanım";
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(922, 31);
            // 
            // grd
            // 
            this.grd.DataSource = this.sEvraklarResultBindingSource;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 143);
            this.grd.MainView = this.gv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.imageOnek,
            this.repositoryItemPictureEdit1,
            this.pictureOnek,
            this.cmbMeslek,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemProgressBar1});
            this.grd.Size = new System.Drawing.Size(922, 360);
            this.grd.TabIndex = 2;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // sEvraklarResultBindingSource
            // 
            this.sEvraklarResultBindingSource.DataSource = typeof(BarduckCRM.S_Evraklar_Result);
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSonuc,
            this.colID,
            this.colEvrakTanimBasligi,
            this.colAciklamalar,
            this.colAktif,
            this.colDosyaAdi,
            this.colDurumSecID_400,
            this.colEvrakGosterimYeriID,
            this.colYetkilendirmeKisID_201,
            this.colSiraNo});
            this.gv.GridControl = this.grd;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsView.ColumnAutoWidth = false;
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // colSonuc
            // 
            this.colSonuc.FieldName = "Sonuc";
            this.colSonuc.Name = "colSonuc";
            this.colSonuc.Width = 150;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 150;
            // 
            // colEvrakTanimBasligi
            // 
            this.colEvrakTanimBasligi.FieldName = "EvrakTanimBasligi";
            this.colEvrakTanimBasligi.Name = "colEvrakTanimBasligi";
            this.colEvrakTanimBasligi.Visible = true;
            this.colEvrakTanimBasligi.VisibleIndex = 1;
            this.colEvrakTanimBasligi.Width = 150;
            // 
            // colAciklamalar
            // 
            this.colAciklamalar.FieldName = "Aciklamalar";
            this.colAciklamalar.Name = "colAciklamalar";
            this.colAciklamalar.Visible = true;
            this.colAciklamalar.VisibleIndex = 2;
            this.colAciklamalar.Width = 150;
            // 
            // colAktif
            // 
            this.colAktif.FieldName = "Aktif";
            this.colAktif.Name = "colAktif";
            this.colAktif.Visible = true;
            this.colAktif.VisibleIndex = 3;
            this.colAktif.Width = 150;
            // 
            // colDosyaAdi
            // 
            this.colDosyaAdi.FieldName = "DosyaAdi";
            this.colDosyaAdi.Name = "colDosyaAdi";
            this.colDosyaAdi.Visible = true;
            this.colDosyaAdi.VisibleIndex = 4;
            this.colDosyaAdi.Width = 150;
            // 
            // colDurumSecID_400
            // 
            this.colDurumSecID_400.FieldName = "DurumSecID_400";
            this.colDurumSecID_400.Name = "colDurumSecID_400";
            this.colDurumSecID_400.Visible = true;
            this.colDurumSecID_400.VisibleIndex = 5;
            this.colDurumSecID_400.Width = 150;
            // 
            // colEvrakGosterimYeriID
            // 
            this.colEvrakGosterimYeriID.FieldName = "EvrakGosterimYeriID";
            this.colEvrakGosterimYeriID.Name = "colEvrakGosterimYeriID";
            this.colEvrakGosterimYeriID.Visible = true;
            this.colEvrakGosterimYeriID.VisibleIndex = 6;
            this.colEvrakGosterimYeriID.Width = 150;
            // 
            // colYetkilendirmeKisID_201
            // 
            this.colYetkilendirmeKisID_201.FieldName = "YetkilendirmeKisID_201";
            this.colYetkilendirmeKisID_201.Name = "colYetkilendirmeKisID_201";
            this.colYetkilendirmeKisID_201.Visible = true;
            this.colYetkilendirmeKisID_201.VisibleIndex = 7;
            this.colYetkilendirmeKisID_201.Width = 150;
            // 
            // colSiraNo
            // 
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.Visible = true;
            this.colSiraNo.VisibleIndex = 8;
            this.colSiraNo.Width = 150;
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
            // DashboardTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 534);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DashboardTanim";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Dashboard Tanım";
            this.Load += new System.EventHandler(this.DashboardTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEvraklarResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeslek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnEkle;
        private DevExpress.XtraBars.BarButtonItem btnDuzenle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pictureOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbMeslek;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit imageOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private System.Windows.Forms.BindingSource sEvraklarResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSonuc;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakTanimBasligi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklamalar;
        private DevExpress.XtraGrid.Columns.GridColumn colAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colDosyaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumSecID_400;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakGosterimYeriID;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkilendirmeKisID_201;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
    }
}
namespace BarduckCRM
{
    partial class Kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.sKullaniciResultBindingSource = new System.Windows.Forms.BindingSource();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCikisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfilID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageOnek = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.pictureOnek = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.cmbMeslek = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKullaniciResultBindingSource)).BeginInit();
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
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(442, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Caption = "Ekle";
            this.btnEkle.Id = 1;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.LargeImage")));
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEkle_ItemClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Caption = "Düzenle";
            this.btnDuzenle.Id = 2;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.LargeImage")));
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuzenle_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 3;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.Name = "btnSil";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kullanıcılar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDuzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Kaydet";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // grd
            // 
            this.grd.DataSource = this.sKullaniciResultBindingSource;
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
            this.grd.Size = new System.Drawing.Size(442, 275);
            this.grd.TabIndex = 4;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // sKullaniciResultBindingSource
            // 
            this.sKullaniciResultBindingSource.DataSource = typeof(BarduckCRM.S_Kullanici_Result);
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKullaniciAdi,
            this.colParola,
            this.colKayitTarihi,
            this.colGirisTarihi,
            this.colCikisTarihi,
            this.colPersonelID,
            this.colProfilID});
            this.gv.GridControl = this.grd;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsView.ColumnAutoWidth = false;
            this.gv.DoubleClick += new System.EventHandler(this.gv_DoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 150;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 1;
            this.colKullaniciAdi.Width = 150;
            // 
            // colParola
            // 
            this.colParola.FieldName = "Parola";
            this.colParola.Name = "colParola";
            this.colParola.OptionsColumn.AllowEdit = false;
            this.colParola.Width = 150;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.OptionsColumn.AllowEdit = false;
            this.colKayitTarihi.Width = 150;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.OptionsColumn.AllowEdit = false;
            this.colGirisTarihi.Width = 150;
            // 
            // colCikisTarihi
            // 
            this.colCikisTarihi.FieldName = "CikisTarihi";
            this.colCikisTarihi.Name = "colCikisTarihi";
            this.colCikisTarihi.OptionsColumn.AllowEdit = false;
            this.colCikisTarihi.Width = 150;
            // 
            // colPersonelID
            // 
            this.colPersonelID.FieldName = "PersonelID";
            this.colPersonelID.Name = "colPersonelID";
            this.colPersonelID.OptionsColumn.AllowEdit = false;
            this.colPersonelID.Width = 150;
            // 
            // colProfilID
            // 
            this.colProfilID.FieldName = "ProfilID";
            this.colProfilID.Name = "colProfilID";
            this.colProfilID.OptionsColumn.AllowEdit = false;
            this.colProfilID.Width = 150;
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
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanici";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKullaniciResultBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit imageOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pictureOnek;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbMeslek;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private System.Windows.Forms.BindingSource sKullaniciResultBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colCikisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelID;
        private DevExpress.XtraGrid.Columns.GridColumn colProfilID;
    }
}
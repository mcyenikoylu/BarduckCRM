namespace DXApplication2
{
    partial class MenuStokYonetimi
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStokYonetimi));
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.galleryControl1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainer1.Size = new System.Drawing.Size(766, 624);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 4;
            // 
            // galleryControl1
            // 
            this.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
            this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.galleryControl1.Gallery.AutoFitColumns = false;
            this.galleryControl1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            this.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent;
            this.galleryControl1.Gallery.ColumnCount = 1;
            this.galleryControl1.Gallery.DistanceItemImageToText = 20;
            this.galleryControl1.Gallery.DrawImageBackground = false;
            galleryItemGroup1.Caption = "Group1";
            galleryItem1.Caption = "Proje Kartları";
            galleryItem1.Description = "Gayrimenkullerinizin hangi projelerde oladuğunu ve derinlemesine detaylarnı barın" +
    "dıran, durum ve hareketlerini göreceğiniz ekranlar.";
            galleryItem1.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem1.Image")));
            galleryItem1.Value = "18";
            galleryItem2.Caption = "Vaziyet Planı";
            galleryItem2.Description = "Projeniz hakkında detaylı bilgiler girebilirsiniz ve vaziyet olarak projenizi det" +
    "aylandırırsınız.";
            galleryItem2.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem2.Image")));
            galleryItem2.ImageIndex = 1;
            galleryItem2.Value = "19";
            galleryItem3.Caption = "Gayrimenkul Kartları";
            galleryItem3.Description = "Bütün detaylarıyla gayrimenkul bilgilerini girip hızlıca satışa hazırlayabilirsin" +
    "iz.";
            galleryItem3.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem3.Image")));
            galleryItem3.Value = "20";
            galleryItem4.Caption = "Fiyat Listeleri";
            galleryItem4.Description = "Gayrimenkul fiyatlarını tanımlayabileceğiniz ve farklı satış listeleri oluşturabi" +
    "lirsiniz.";
            galleryItem4.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem4.Image")));
            galleryItem4.Value = "21";
            galleryItem5.Caption = "Kampanya Yönetimi";
            galleryItem5.Description = "Çeşitli kampanyalar tanımlayabileceğiniz ve bunları yönetebileceğinizi ekran.";
            galleryItem5.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem5.Image")));
            galleryItem5.Value = "22";
            galleryItem6.Caption = "İçeri Aktarımlar";
            galleryItem6.Description = "Excel üzerinde olan gayrimenkul bilgilerinizi sistem içerisine aktarımını sağlar." +
    "";
            galleryItem6.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem6.Image")));
            galleryItem6.Value = "23";
            galleryItem7.Caption = "Raporlar";
            galleryItem7.Description = "Stok verilerine özgü detaylı raporlar ve hareket bilgileri alabilirsiniz. Kendi f" +
    "iltrelerinizi kaydedip, kendi raporlarınızı yapabilirsiniz.";
            galleryItem7.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem7.Image")));
            galleryItem7.Value = "24";
            galleryItem8.Caption = "Tanımlamalar";
            galleryItem8.Description = "Çeşitli dinamik alanların verilerini ve içeriklerini tanımlaya bilirsiniz. İhtiya" +
    "çlarınız doğrultusunda kategoriler yaratabilirsiniz.";
            galleryItem8.Image = ((System.Drawing.Image)(resources.GetObject("galleryItem8.Image")));
            galleryItem8.Value = "25";
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8});
            this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.galleryControl1.Gallery.ShowGroupCaption = false;
            this.galleryControl1.Gallery.ShowItemText = true;
            this.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemClick);
            this.galleryControl1.Location = new System.Drawing.Point(20, 58);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(374, 410);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(0, 0);
            this.galleryControlClient1.Size = new System.Drawing.Size(374, 10000);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.ShowLineShadow = false;
            this.labelControl2.Size = new System.Drawing.Size(374, 38);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Stok Yönetimi";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 624);
            this.labelControl1.TabIndex = 0;
            // 
            // MenuStokYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MenuStokYonetimi";
            this.Size = new System.Drawing.Size(766, 624);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

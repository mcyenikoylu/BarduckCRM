namespace BarduckCRM
{
    partial class QueryBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBuilder));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQueryOlustur = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSPAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKullaniciAdi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbTablo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mSelect = new DevExpress.XtraEditors.MemoEdit();
            this.mInsert = new DevExpress.XtraEditors.MemoEdit();
            this.sBaglantiResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTablo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInsert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaglantiResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnQueryOlustur});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(747, 143);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnQueryOlustur
            // 
            this.btnQueryOlustur.Caption = "Query Oluştur";
            this.btnQueryOlustur.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQueryOlustur.Glyph")));
            this.btnQueryOlustur.Id = 1;
            this.btnQueryOlustur.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQueryOlustur.LargeGlyph")));
            this.btnQueryOlustur.Name = "btnQueryOlustur";
            this.btnQueryOlustur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQueryOlustur_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Query Builder";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQueryOlustur);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Veritabanı İşlemleri";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtSPAdi);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbKullaniciAdi);
            this.panelControl1.Controls.Add(this.cmbTablo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(747, 95);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 22);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Kullanıcı Adı";
            // 
            // txtSPAdi
            // 
            this.txtSPAdi.Location = new System.Drawing.Point(121, 33);
            this.txtSPAdi.MenuManager = this.ribbonControl1;
            this.txtSPAdi.Name = "txtSPAdi";
            this.txtSPAdi.Size = new System.Drawing.Size(305, 20);
            this.txtSPAdi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 22);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "SP Adı: S_ / IUD_";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 22);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Tablo";
            // 
            // cmbKullaniciAdi
            // 
            this.cmbKullaniciAdi.EditValue = "";
            this.cmbKullaniciAdi.Location = new System.Drawing.Point(121, 59);
            this.cmbKullaniciAdi.MenuManager = this.ribbonControl1;
            this.cmbKullaniciAdi.Name = "cmbKullaniciAdi";
            this.cmbKullaniciAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKullaniciAdi.Properties.Items.AddRange(new object[] {
            "M. Cenk YENİKÖYLÜ"});
            this.cmbKullaniciAdi.Properties.PopupSizeable = true;
            this.cmbKullaniciAdi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbKullaniciAdi.Size = new System.Drawing.Size(305, 20);
            this.cmbKullaniciAdi.TabIndex = 1;
            // 
            // cmbTablo
            // 
            this.cmbTablo.Location = new System.Drawing.Point(121, 7);
            this.cmbTablo.MenuManager = this.ribbonControl1;
            this.cmbTablo.Name = "cmbTablo";
            this.cmbTablo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTablo.Properties.DisplayMember = "TABLE_NAME";
            this.cmbTablo.Properties.ImmediatePopup = true;
            this.cmbTablo.Properties.NullText = "";
            this.cmbTablo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbTablo.Properties.ShowFooter = false;
            this.cmbTablo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTablo.Properties.ValueMember = "TABLE_NAME";
            this.cmbTablo.Properties.View = this.gridLookUpEdit1View;
            this.cmbTablo.Size = new System.Drawing.Size(305, 20);
            this.cmbTablo.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 238);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.mSelect);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.mInsert);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(747, 265);
            this.splitContainerControl1.SplitterPosition = 368;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            this.splitContainerControl1.Resize += new System.EventHandler(this.splitContainerControl1_Resize);
            // 
            // mSelect
            // 
            this.mSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mSelect.Location = new System.Drawing.Point(0, 0);
            this.mSelect.MenuManager = this.ribbonControl1;
            this.mSelect.Name = "mSelect";
            this.mSelect.Size = new System.Drawing.Size(368, 265);
            this.mSelect.TabIndex = 0;
            // 
            // mInsert
            // 
            this.mInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mInsert.Location = new System.Drawing.Point(0, 0);
            this.mInsert.MenuManager = this.ribbonControl1;
            this.mInsert.Name = "mInsert";
            this.mInsert.Size = new System.Drawing.Size(374, 265);
            this.mInsert.TabIndex = 0;
            // 
            // sBaglantiResultBindingSource
            // 
            this.sBaglantiResultBindingSource.DataSource = typeof(BarduckCRM.S_Baglanti_Result);
            // 
            // QueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 503);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryBuilder";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Query Builder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QueryBuilder_Load);
            this.Shown += new System.EventHandler(this.QueryBuilder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSPAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTablo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInsert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBaglantiResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnQueryOlustur;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSPAdi;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.MemoEdit mSelect;
        private DevExpress.XtraEditors.MemoEdit mInsert;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKullaniciAdi;
        private DevExpress.XtraEditors.GridLookUpEdit cmbTablo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource sBaglantiResultBindingSource;
    }
}
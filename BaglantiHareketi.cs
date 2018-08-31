using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.Utils.Menu;
using System.IO;
using DevExpress.XtraBars.Docking;
using BarduckCRM;

namespace BarduckCRM
{
    public partial class BaglantiHareketi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        bool formyuklendi = false;
        public BaglantiHareketi()
        {
            InitializeComponent();
        }
        private Image GetImageFromResource(string fileName)
        {
            Stream resource = typeof(Master).Assembly.GetManifestResourceStream("ImagesInCells.Resources." + fileName);
            return Image.FromStream(resource);
        }
        private byte[] GetImageData(string fileName)
        {
            Image img = GetImageFromResource(fileName);
            MemoryStream mem = new MemoryStream();
            img.Save(mem, System.Drawing.Imaging.ImageFormat.Bmp);
            return mem.GetBuffer();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            try
            {
                tabPane1.SelectedPageIndex = 0;
                
                splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
                splitContainerControl1.SplitterPosition = this.Width / 3;
                //xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
                panelControl1.Invalidate();

                RibbonMenuGridAyarlari uc_gridAyarlari = new RibbonMenuGridAyarlari(ribbonPage1.Text);
                uc_gridAyarlari.GrdView = gvBaglanti;
                //InsertItem(0, "test", uc_gridAyarlari);
                ribbonControl1.MergeRibbon(uc_gridAyarlari.ribbonControl1);

                Cursor.Current = Cursors.WaitCursor;

                var meslek = data.S_Tip(2).ToList();
                if (meslek.Count > 0)
                    cmbMeslek.DataSource = meslek;

                var personel = data.S_Personel(-1).ToList();
                if (personel.Count > 0)
                    cmbPersonelID.DataSource = personel;

                var tip = data.S_Tip(17).ToList();
                if (tip.Count > 0)
                    cmbHareketTipi.DataSource = tip;

                //lblHareketler_Click(null,null);

                //pictureEdit1.Properties.ContextMenuStrip = new ContextMenuStrip();

                BaglantiDataGetir(-1);

                formyuklendi = true;

                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {

            }
        }

        //protected void InsertItem(int index, string item, Control userControl)
        //{
        //    DockPanel dp = dockManager1.AddPanel(DockingStyle.Right);
        //    dp.Text = item;
        //    dp.TabText = item;
        //    userControl.Dock = DockStyle.Fill;
        //    dp.ControlContainer.Controls.Add(userControl);

        //    //tabbedView1.BeginUpdate();
        //    //tabbedView1.Controller.Dock(dp);
        //    //tabbedView1.EndUpdate();

        //}

        private void BaglantiDataGetir(int _islemid)
        {
            var baglanti = data.S_Baglanti(_islemid).ToList();
            if (baglanti.Count > 0)
                grdBaglanti.DataSource = baglanti;
        }

        private void XtraForm1_SizeChanged(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = this.Width / 3;
        }

        //DXPopupMenu menu = null;
        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
            //PictureEdit edit = sender as PictureEdit;
            //if (menu == null)
            //{
            //    PropertyInfo info = typeof(PictureEdit).GetProperty("Menu", BindingFlags.NonPublic | BindingFlags.Instance);
            //    menu = info.GetValue(edit, null) as DXPopupMenu;
            //    menu.Items.Add(new DXMenuItem("MyItem", new EventHandler(OnMyItemClick), SystemIcons.Application.ToBitmap()));
            //}
        }

        public void OnMyItemClick(object sender, EventArgs e)
        {
            //XtraMessageBox.Show("MyItemClick");
        }

        private void gvBaglanti_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int id = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            var baglanti = data.S_Baglanti(id).ToList();
            if (baglanti.Count > 0)
            {
                lblAdiSoyadi.Text = baglanti.FirstOrDefault().AdiSoyadi;
                lblMeslek.Text = baglanti.FirstOrDefault().Meslek_TipID2_STR + ", " + baglanti.FirstOrDefault().Sehir;
            }
            var hareketler = data.S_BaglantiHareketleri(-1, id).ToList();
            if (hareketler.Count > 0)
                grdHareketler.DataSource = hareketler;
            else
                grdHareketler.DataSource = null;
        }

        //private void lblHareketler_Click(object sender, EventArgs e)
        //{
        //    //xtraTabControl1.SelectedTabPage = tabHareketler;
        //    //lblHareketler.Font = new Font(lblHareketler.Font.FontFamily, 11, FontStyle.Bold);
        //    //lblHareketler.Width = lblHareketler.Width + 10;

        //    if (!formyuklendi)
        //        return;

        //    //lblSatisSiparis.Font = new Font(lblSatisSiparis.Font.FontFamily, 11);
        //    //lblSatisSiparis.Width = lblSatisSiparis.Width - 20;
        //}

        //private void lblSatisSiparis_Click(object sender, EventArgs e)
        //{
        //    lblHareketler.Font = new Font(lblHareketler.Font.FontFamily, 11);
        //    lblHareketler.Width = lblHareketler.Width - 10;

        //    xtraTabControl1.SelectedTabPage = tabSatisSiparis;
        //    lblSatisSiparis.Font = new Font(lblSatisSiparis.Font.FontFamily, 11, FontStyle.Bold);
        //    lblSatisSiparis.Width = lblSatisSiparis.Width + 20;
        //}

        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 0;
            int baglantiid = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            int id = Convert.ToInt32(gvHareketler.GetFocusedRowCellValue("ID"));
            int rowhandle = gvHareketler.FocusedRowHandle;
            BaglantiHareketiKarti frm = new BaglantiHareketiKarti(id, baglantiid);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                gvBaglanti_FocusedRowChanged(null, null);
            }
            gvHareketler.FocusedRowHandle = rowhandle;
        }

        private void btnHareketEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int baglantiid = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            BaglantiHareketiKarti frm = new BaglantiHareketiKarti(-1, baglantiid);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                gvBaglanti_FocusedRowChanged(null, null);
            }
        }

        private void btnHareketDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            advBandedGridView1_DoubleClick(null, null);
        }

        private void btnHareketSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int baglantiid = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
                int id = Convert.ToInt32(gvHareketler.GetFocusedRowCellValue("ID"));
                data.IUD_BaglantiHareketleri(true, id, baglantiid, -1, null, null, "", -1, -1, -1, "", -1, -1, false, -1, false, -1, false, -1, -1, false, -1, null, -1, null, false, false, false, -1, -1, -1);
                gvBaglanti_FocusedRowChanged(null, null);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
            }
        }

        private void btnBaglantiEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaglantiKarti frm = new BaglantiKarti(-1);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BaglantiDataGetir(-1);
            }
        }

        private void btnBaglantiDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int baglantiid = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            BaglantiKarti frm = new BaglantiKarti(baglantiid);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BaglantiDataGetir(-1);
            }
        }

        private void gvBaglanti_DoubleClick(object sender, EventArgs e)
        {
            int baglantiid = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            int rowhandle = gvBaglanti.FocusedRowHandle;
            BaglantiKarti frm = new BaglantiKarti(baglantiid);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BaglantiDataGetir(-1);
            }
            gvBaglanti.FocusedRowHandle = rowhandle;
        }
    }
}
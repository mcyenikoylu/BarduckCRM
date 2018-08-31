using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars;
using BarduckCRM;
using DevExpress.XtraTabbedMdi;

namespace BarduckCRM
{

    public partial class MenuTelekomunikasyonYonetimi : DevExpress.XtraEditors.XtraUserControl
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        private DevExpress.XtraBars.Ribbon.RibbonControl _Ribbon;
        public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
        {
            get
            {
                return _Ribbon;
            }
            set
            {
                _Ribbon = value;
            }
        }

        List<Size> sizes;
        public MenuTelekomunikasyonYonetimi()
        {
            InitializeComponent();
            sizes = new List<System.Drawing.Size>();
            sizes.Add(new Size(48, 48));
            sizes.Add(new Size(32, 32));
            sizes.Add(new Size(24, 24));
            sizes.Add(new Size(16, 16));
            SizeChanged += new EventHandler(XtraUserControl1_SizeChanged);
        }

        void XtraUserControl1_SizeChanged(object sender, EventArgs e)
        {
            Size size = Size.Empty;
            if (Width > 600)
                size = sizes[1];
            if (Width <= 600 && Width > 400)
                size = sizes[1];
            if (Width <= 400 && Width > 200)
                size = sizes[2];
            if (Width <= 200)
                size = sizes[3];
            galleryControl1.Gallery.ImageSize = size;
        }

        private void galleryControl1_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            BackstageViewControl bvc = Parent.Parent as BackstageViewControl;
            bvc.Ribbon.HideApplicationButtonContentControl();

            int value = Convert.ToInt32(e.Item.Value);
            if (value == 8)
            {
                Ofis frm = new Ofis();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 9)
            {
                Personel frm = new Personel();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 10)
            {
                PersonelTakimlari frm = new PersonelTakimlari();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 11)
            {
                PersonelTakimlariYetkileri frm = new PersonelTakimlariYetkileri();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 12)
            {
                Firma frm = new Firma();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }

        }

        private void galleryControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        GalleryItem item = null;
        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = galleryControl1.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = galleryControl1.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                item = hitInfo.GalleryItem;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ekle
            //if (item != null)
            //    XtraMessageBox.Show(item.Value.ToString(), "mcy", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var formlist = data.S_Form(Convert.ToInt32(item.Value)).ToList();
            string FormAdi = formlist.FirstOrDefault().FormAdi;
            string FormBaslik = formlist.FirstOrDefault().FormBaslik;

            RibbonPageGroup grp = Ribbon.Pages[1].Groups[0];

            BarButtonItem itm = new BarButtonItem();

            foreach (BarItemLink lnk in grp.ItemLinks)
            {
                BarItem item = lnk.Item;
                if (item.Name == FormAdi) return;

            }

            XtraForm frm = FormBul(FormAdi);
            itm.Glyph = frm.Icon.ToBitmap();
            itm.LargeGlyph = frm.Icon.ToBitmap();

            itm.Name = FormAdi;
            itm.Caption = FormBaslik;
            grp.ItemLinks.Add(itm);
            itm.ItemClick += itmForm_ItemClick;//itm_ItemClick;

            //Mesaj.MesajVer(String.Format("", FormBaslik), Mesaj.MesajTipi.Bilgi, Master.);
            XtraMessageBox.Show("Seçmiş olduğunuz menü, Sık Kullanılanlar menüsüne eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private RibbonForm FormBul(string FormAdi)
        {
            try
            {
                if (FormAdi == "") return null;

                string FormTypeFullName = string.Format("{0}.{1}", this.GetType().Namespace, FormAdi);
                Type type = Type.GetType(FormTypeFullName, true);
                RibbonForm frm = (RibbonForm)Activator.CreateInstance(type);
                return frm;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void itmForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BenimMenumItemClickMethod(e);
                //XtraMessageBox.Show("tıklandı.");
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BenimMenumItemClickMethod(ItemClickEventArgs e)
        {
            try
            {
                RibbonForm f = FormBul(e.Item.Name);
                if (MDIFormAcikMi(f))
                {
                    XtraMdiTabPage page = FindPageByText(f.Text);
                    xtraTabbedMdiManager1.SelectedPage = page;
                    Ribbon.HideApplicationButtonContentControl();
                    return;
                }
                Ribbon.HideApplicationButtonContentControl();
                f.Ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
                f.MdiParent = Master.ActiveForm; //this;
                f.Show();
                Ribbon.SelectedPage = f.Ribbon.Pages[0];
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool MDIFormAcikMi(XtraForm frm)
        {
            try
            {
                Form AcikFormlar = Application.OpenForms[frm.Name];
                if (AcikFormlar == null)
                    return false;
                else
                    return true;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

        }

        private XtraMdiTabPage FindPageByText(string pageText)
        {
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if (page.MdiChild.Text == pageText)
                    return page;
            }
            return null;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //çıkart
            //if (item != null)
            //    item.GalleryGroup.Items.Remove(item);

            var formlist = data.S_Form(Convert.ToInt32(item.Value)).ToList();
            string FormBaslik = formlist.FirstOrDefault().FormBaslik;
            RibbonPageGroup grp = Ribbon.Pages[1].Groups[0];
            foreach (BarItemLink lnk in grp.ItemLinks)
            {
                if (lnk.Caption == FormBaslik)
                {
                    grp.ItemLinks.Remove(lnk);
                    //Ayar.InfoMesajGoster(String.Format(Genel.DilGetirMesaj(8), FormBaslik), Ayar.MesajTipi.Bilgi, this);
                    break;
                }
            }
            XtraMessageBox.Show("Seçmiş olduğunuz menü, Sık Kullanılanlar menüsünden kaldırılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void popupMenu1_CloseUp(object sender, EventArgs e)
        {
            item = null;
        }

        private void popupMenu1_BeforePopup(object sender, CancelEventArgs e)
        {
            (sender as DevExpress.XtraBars.PopupMenu).ItemLinks[0].Item.Enabled = true;
            (sender as DevExpress.XtraBars.PopupMenu).ItemLinks[1].Item.Enabled = false;

            Point point = galleryControl1.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = galleryControl1.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                item = hitInfo.GalleryItem;

            if (item != null)
            {
                var menulist = data.S_Menu(-1).Where(c => c.FormID == Convert.ToInt32(item.Value)).ToList();
                RibbonPageGroup grp = Ribbon.Pages[1].Groups[0]; //BenimMenum

                foreach (BarItemLink lnk in grp.ItemLinks)
                {
                    if (lnk.Item.Name == menulist.FirstOrDefault().FormAdi)
                    {
                        (sender as DevExpress.XtraBars.PopupMenu).ItemLinks[0].Item.Enabled = false;
                        (sender as DevExpress.XtraBars.PopupMenu).ItemLinks[1].Item.Enabled = true;
                    }
                   
                }
            }
        }













    }
}

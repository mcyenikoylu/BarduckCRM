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

namespace DXApplication2
{
    public partial class MenuStokYonetimi : DevExpress.XtraEditors.XtraUserControl
    {
        List<Size> sizes;

        public MenuStokYonetimi()
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
            if (value == 18)
            {
                Proje frm = new Proje();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 19)
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 20)
            {
                Gayrimenkul frm = new Gayrimenkul();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 21)
            {
                FiyatListesi frm = new FiyatListesi();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 22)
            {
                Kampanya frm = new Kampanya();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 23)
            {
                Aktarim frm = new Aktarim();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 24)
            {
                Rapor frm = new Rapor();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 25)
            {
                Tanimlama frm = new Tanimlama();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }




        }
    }
}

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

namespace BarduckCRM
{
    public partial class MenuRaporlar : DevExpress.XtraEditors.XtraUserControl
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

        public MenuRaporlar()
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
            if (value == 50) //performans raporlar
            {
                Proje frm = new Proje();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 51) //satış raporu
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 52) //gelen ödemeler
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 53) //bekleyen ödemeler
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 54) //firma komisyonları
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 55) //personel primleri
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 56) //dashboard ekranları
            {
                DashboardTanim frm = new DashboardTanim();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
        }
    }
}

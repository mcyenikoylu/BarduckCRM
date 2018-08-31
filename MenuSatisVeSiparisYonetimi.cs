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
    public partial class MenuSatisVeSiparisYonetimi : DevExpress.XtraEditors.XtraUserControl
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

        public MenuSatisVeSiparisYonetimi()
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
            if (value == 40) //satışa hazırlar
            {
                Proje frm = new Proje();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 41) //tüm satışlar
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 42) //satış iptalleri
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 43) //verilen teklifler
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 44) //rezerveler
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 45) //rezerve iptalleri
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 46) //raporlar
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }
            else if (value == 47) //tanımlamalar
            {
                Vaziyet frm = new Vaziyet();
                frm.MdiParent = Master.ActiveForm;
                frm.Show();
            }


        }
    }
}

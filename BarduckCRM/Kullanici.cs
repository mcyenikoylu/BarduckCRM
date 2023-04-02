using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BarduckCRM
{
    public partial class Kullanici : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        public Kullanici()
        {
            InitializeComponent();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            RibbonMenuGridAyarlari uc_gridAyarlari = new RibbonMenuGridAyarlari(ribbonPage1.Text);
            uc_gridAyarlari.GrdView = gv;
            ribbon.MergeRibbon(uc_gridAyarlari.ribbonControl1);

            DataGetir();
        }

        private void btnEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            KullaniciKarti frm = new KullaniciKarti(-1);
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void btnDuzenle_ItemClick(object sender, ItemClickEventArgs e)
        {
            int KullaniciID = Convert.ToInt32(gv.GetFocusedRowCellValue("ID"));
            KullaniciKarti frm = new KullaniciKarti(KullaniciID);
            frm.ShowDialog();
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            int KullaniciID = Convert.ToInt32(gv.GetFocusedRowCellValue("ID"));
            KullaniciKarti frm = new KullaniciKarti(KullaniciID);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void DataGetir()
        {
            var list = data.S_Kullanici(-1).ToList();
            if (list.Count > 0)
                grd.DataSource = list;
            else
                grd.DataSource = null;
        }
    }
}
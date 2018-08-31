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
    public partial class DashboardTanim : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        public DashboardTanim()
        {
            InitializeComponent();
        }

        private void DashboardTanim_Load(object sender, EventArgs e)
        {
            var list = data.S_Evraklar(-1,true,1).ToList();
            grd.DataSource = list;
        }

        private void btnEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            DashboardKarti frm = new DashboardKarti(-1,"");
            frm.ShowDialog();
        }

        private void btnDuzenle_ItemClick(object sender, ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gv.GetFocusedRowCellValue("ID"));
            string dosyaadi = gv.GetFocusedRowCellValue("DosyaAdi").ToString();
            DashboardKarti frm = new DashboardKarti(id, dosyaadi);
            frm.ShowDialog();
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gv.GetFocusedRowCellValue("ID"));
            string dosyaadi = gv.GetFocusedRowCellValue("DosyaAdi").ToString();
            DashboardKarti frm = new DashboardKarti(id, dosyaadi);
            frm.ShowDialog();
        }
    }
}
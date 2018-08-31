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
using BarduckCRM;

namespace BarduckCRM
{
    public partial class SadakatYonetimi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        public SadakatYonetimi()
        {
            InitializeComponent();
        }

        private void SadakatYonetimi_Load(object sender, EventArgs e)
        {
            var meslek = data.S_Tip(2).ToList();
            cmbMeslek.DataSource = meslek;

            var baglanti = data.S_Baglanti(-1).ToList();
            grdBaglanti.DataSource = baglanti;
        }

        private void btnPuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            int baglantiid = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            SadakatPuani frm = new SadakatPuani(baglantiid);
            frm.ShowDialog();

        }
    }
}
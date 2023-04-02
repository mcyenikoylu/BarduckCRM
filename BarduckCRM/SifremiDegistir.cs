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
using DevExpress.XtraEditors;

namespace BarduckCRM
{
    public partial class SifremiDegistir : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        public SifremiDegistir()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //kaydet

            var list = data.S_KullaniciGirisKontrol(Genel.AktifKullaniciAdi, txtEskiParola.Text).ToList();
            if (Convert.ToInt32(list.FirstOrDefault().ID) > 0)
            {
                if (txtParola.Text == txtTekrarParola.Text)
                {
                    if (XtraMessageBox.Show("Değişikliklerin kayıt olması için program yeniden başlatılacaktır.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        data.U_KullaniciParola(Genel.AktifKullaniciID, txtParola.Text);
                        Application.Restart();
                    }
                    else
                        XtraMessageBox.Show("Parola değişiklik işlemini iptal ettiniz.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    XtraMessageBox.Show("Eşleşmeyen parola girişi yaptınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                XtraMessageBox.Show("Eski parola hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

       
    }
}
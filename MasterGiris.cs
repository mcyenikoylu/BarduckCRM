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
using System.IO;
using BarduckCRM;

namespace BarduckCRM
{
    public partial class MasterGiris : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= 0x20000;  //Formun etrafına gölge ekler.
        //        cp.ExStyle |= 0x02000000; //Formun background image'dan dolayı titremesini önler
        //        return cp;
        //    }
        //}

        BarduckCRMEntities data = new BarduckCRMEntities();

        public MasterGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int kullaniciid = 0;
            string KullaniciAyarlari = "";

            if (Convert.ToBoolean(toggHatirla.EditValue))
            {
                KullaniciAyarlari += txtKullaniciAdi.Text.Trim() + ";";
            }
            else
            {
                KullaniciAyarlari += ";";
            }
            KullaniciAyarlari += toggHatirla.EditValue.ToString() + ";";

            Genel.TextDosyaYaz(Genel.ProgramYolu + "PrmParams.txt", KullaniciAyarlari);

            var list = data.S_KullaniciGirisKontrol(txtKullaniciAdi.Text, txtParola.Text).ToList();
            if (Convert.ToInt32(list.FirstOrDefault().ID) > 0)
            {
                kullaniciid = Convert.ToInt32(list.FirstOrDefault().ID);
                Genel.AktifKullaniciID = kullaniciid;

                var ayarlar = data.S_KullaniciAyarlari(kullaniciid).ToList();
                if(ayarlar.Count>0)
                {
                    Genel.AktifKullanici_DashboardID = ayarlar.FirstOrDefault().DashboardID;
                    Genel.AktifKullanici_DashboardOtomatikYenilensinMi = ayarlar.FirstOrDefault().DashboardYenileme;
                    Genel.AktifKullanici_DashboardYenilemeSuresi = ayarlar.FirstOrDefault().DashboardYenilemeSure;
                }
                else
                {
                    Genel.AktifKullanici_DashboardID = 0;
                    Genel.AktifKullanici_DashboardOtomatikYenilensinMi = false;
                    Genel.AktifKullanici_DashboardYenilemeSuresi = 0;
                }
                this.Hide();
                Master frm = new Master();
                frm.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Kullanici Adı veya Parola hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MasterGiris_Load(object sender, EventArgs e)
        {
            barStaticVersiyon.Caption = "Versiyon " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtKullaniciAdi.Focus();
            if (File.Exists(Genel.ProgramYolu + "PrmParams.txt"))
            {
                string[] Ayarlar = Genel.TextDosyaOku(Genel.ProgramYolu + "PrmParams.txt").Split(';');
                string KullaniciAdi = Ayarlar[0];
                bool BeniHatirla = Convert.ToBoolean(Ayarlar[1]);

                if (BeniHatirla)
                {
                    txtKullaniciAdi.Text = KullaniciAdi;
                }
                toggHatirla.EditValue = BeniHatirla;
            }

            //SirketCombosuOlustur();

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }

        private void cmbSirket_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void SirketCombosuOlustur()
        {
            try
            {

                bool bDosyaVarMi = File.Exists("DBList.txt");

                if (!bDosyaVarMi)
                {
                    TextWriter tw = new StreamWriter("DBList.txt", true);
                    tw.Close();
                }
                
                DataTable Liste = new DataTable();
                Liste.Columns.Add("LABEL", typeof(System.String));
                Liste.Columns.Add("SERVER", typeof(System.String));
                Liste.Columns.Add("DB", typeof(System.String));
                
                String line = "";
                using (StreamReader sr = new StreamReader("DBList.txt"))
                {
                    line = sr.ReadToEnd();
                }

                if (line.Length <= 0)
                    return;

                string[] DBList = line.Split(new string[] { System.Environment.NewLine }, System.StringSplitOptions.RemoveEmptyEntries);

                for (int t = 0; t < DBList.Length; t++)
                {
                    if (DBList[t].Trim().Length < 5)
                        continue;

                    string[] arr = DBList[t].Split(';');
                    DataRow drw = Liste.NewRow();
                    drw["LABEL"] = arr[0];
                    drw["SERVER"] = arr[1];
                    drw["DB"] = arr[2];
                    Liste.Rows.Add(drw);
                }
                
                cmbSirket.Properties.DataSource = Liste;
                if (Liste.Rows.Count > 0)
                {
                    cmbSirket.ItemIndex = 0;
                }
                else
                    cmbSirket.Focus();
            }
            catch (Exception exc)
            {
                XtraMessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
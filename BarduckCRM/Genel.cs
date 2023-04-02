using BarduckCRM.Properties;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarduckCRM;
using DevExpress.XtraBars.Docking;
using System.Reflection;

namespace BarduckCRM
{
    
    class Genel
    {
        
        /// <summary>
        /// Aktif sunucu adresini tutar.
        /// </summary>
        public static string Sunucu = "";
        public static string UserName = "";
        public static string Password = "";
        
        /// <summary>
        /// Bağlanılan veritabanını tutar.
        /// </summary>
        public static string Veritabani = "";

        /// <summary>
        /// Sistemde login olan aktif kullanıcı id.
        /// </summary>
        public static int AktifKullaniciID = -1;

        /// <summary>
        /// Sistemde login olan aktif kullanıcı id.
        /// </summary>
        public static string AktifKullaniciAdi = "";

        /// <summary>
        /// Program çalışma dizini
        /// </summary>
        public static string ProgramYolu = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

        /// <summary>
        /// Programa giriş yapan kullanıcının hangi dashboardu kullanacağını tutar.
        /// </summary>
        public static int AktifKullanici_DashboardID = 0;
        /// <summary>
        /// Programa giriş yapan kullanıcı için hatırlatmalar formunun otomatik olarak açılıp açılmayacağını tutar.
        /// </summary>
        public static bool AktifKullanici_DashboardOtomatikYenilensinMi = false;
        /// <summary>
        /// Programa giriş yapan kullanıcı için hatırlatmalar formunun kaç dakikada bir açılacağını tutar.
        /// </summary>
        public static int AktifKullanici_DashboardYenilemeSuresi = 10;

        /// <summary>
        /// TXT dosya yazar.
        /// </summary>
        public static void TextDosyaYaz(string DosyaAdi, string Icerik)
        {
            TextWriter tw = new StreamWriter(DosyaAdi);
            tw.WriteLine(Icerik);
            tw.Close();
        }
        /// <summary>
        /// Txt dosya okur.
        /// </summary>
        public static string TextDosyaOku(string DosyaAdi)
        {
            string Text = "";
            using (StreamReader sr = new StreamReader(DosyaAdi))
            {
                String line = sr.ReadToEnd();
                Text += line.Replace("\r\n", "");
            }
            return Text;
        }
        /// <summary>
        /// Stream değişkeni Byte[] diziye dönüştürür. Devexpress layout kaydetme ve çağırma işlemlerinde kullanılır.
        /// </summary>
        public static byte[] StreamToByteArray(Stream inputStream)
        {
            if (!inputStream.CanRead)
            {
                throw new ArgumentException();
            }

            if (inputStream.CanSeek)
            {
                inputStream.Seek(0, SeekOrigin.Begin);
            }

            byte[] output = new byte[inputStream.Length];
            int bytesRead = inputStream.Read(output, 0, output.Length);
            return output;
        }

        /// <summary>
        /// Byte[] değişkeni Stream'e dönüştürür. Devexpress layout kaydetme ve çağırma işlemlerinde kullanılır.
        /// </summary>
        public static Stream ByteArrayToStream(object Data)
        {
            try
            {
                if (Data != DBNull.Value)
                {
                    Byte[] b = (Byte[])Data;
                    if (b.Length > 0)
                    {
                        System.IO.Stream stream = new System.IO.MemoryStream(b);
                        return stream;
                    }
                    else
                        return null;
                }
                else
                    return null;

            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public static DataSet DsGetir(int SelectedReportID, bool DevexDashboardMu)
        {
            BarduckCRMEntities data = new BarduckCRMEntities();
            DataSet fulldata = new DataSet();
            //var Evrak = data.S_Evraklar(SelectedReportID, DevexDashboardMu, 1).FirstOrDefault();
            //if (Evrak.DataSourceKullaniciTanimliMi)
            //{
            //    MyDatabase sql = new MyDatabase();
            //    sql.DatabaseName = Genel.Veritabani;
            //    sql.ServerName = Genel.Sunucu;
            //    sql.UserName = Genel.UserName;
            //    sql.Password = Genel.Password;
            //    bool bbbb = sql.CreateConnection();

            //    DataTable dt = new DataTable();
            //    try
            //    {
            //        dt = sql.ExecuteDataTable(" SELECT  TD.QueryIcerik		, EvrakDataSourceName	   FROM T_SecmeliAlanlarData TS WITH(NOLOCK)    INNER JOIN Tn_EvrakDataSource TD WITH(NOLOCK) ON TD.ID = TS.KartID   WHERE TS.SecmeliAlanlarID IN (20,21) AND TS.KayitID = " + SelectedReportID + "");


            //        fulldata.Tables.Clear();

            //        foreach (DataRow row in dt.Rows)
            //        {
            //            var Queryicerik = row["QueryIcerik"].ToString();
            //            var EvrakDataSourceName = row["EvrakDataSourceName"].ToString();

            //            Queryicerik = Queryicerik.Replace("@DilID", Genel.DilID.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID01", MusteriID == null ? "" : MusteriID.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID02", ProjeID == null ? "" : ProjeID.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID03", AktiviteID == null ? "" : AktiviteID.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID04", Parametre4 == null ? "" : Parametre4.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID05", Parametre5 == null ? "" : Parametre5.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID06", Parametre6 == null ? "" : Parametre6.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID07", Parametre7 == null ? "" : Parametre7.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID08", Parametre8 == null ? "" : Parametre8.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID09", Parametre9 == null ? "" : Parametre9.Value.ToString());
            //            Queryicerik = Queryicerik.Replace("@ID10", Parametre10 == null ? "" : Parametre10.Value.ToString());

            //            dt.TableName = EvrakDataSourceName;
            //            if (Queryicerik != "")
            //            {
            //                dt = sql.ExecuteDataTable(Queryicerik);
            //                DataTable Dt = new DataTable();
            //                Dt = dt.Copy();
            //                Dt.TableName = EvrakDataSourceName;
            //                fulldata.Tables.Add(Dt);
            //                fulldata.DataSetName = "VERITABANI";
            //            }
            //        }



            //    }
            //    catch (Exception exc)
            //    {
            //    }

            //}
            //else
            //{
                var EvrakDataSourceList = data.S_EvrakDataSourceCalistir(-1, SelectedReportID, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).ToList();
                foreach (var item in EvrakDataSourceList)
                {
                    //if (item.QueryData != "" && item.QueryData.Contains("<row"))
                    if (item.QueryData != "")
                    {
                        DataSet theDataSet = new DataSet();

                        var gelendata = item.QueryData;

                        var indexrow = gelendata.IndexOf("<row");
                        string gelendata2 = "";
                        string gelendata3 = "";
                        if (indexrow > 0)
                        {
                            gelendata2 = gelendata.Substring(0, gelendata.IndexOf("<row"));
                            gelendata3 = item.QueryData.Substring(item.QueryData.IndexOf("<row"), item.QueryData.Length - item.QueryData.IndexOf("<row"));

                        }
                        else
                        {

                            gelendata2 = gelendata;
                        }
                        //gelendata2 = gelendata2.Trim();
                        StringReader theReader = new StringReader(gelendata2);
                        StringReader theReader2 = new StringReader(gelendata3);

                        theDataSet.ReadXmlSchema(theReader);
                        theDataSet.ReadXml(theReader2, XmlReadMode.Fragment);


                        //System.IO.StringWriter writer = new System.IO.StringWriter();
                        //theDataSet.WriteXml(writer);

                        // var asdf = writer;
                        DataTable Dt = new DataTable();
                        Dt = theDataSet.Tables[0].Copy();
                        Dt.TableName = item.TableName;
                        fulldata.Tables.Add(Dt);
                        fulldata.DataSetName = "VERITABANI";

                    }
                }
            //}


            return fulldata;
        }

        #region Dashboard Layout Fonksiyonları
        /// <summary>
        /// Dashboard formundaki layout ayarlarını getirir.
        /// </summary>
        public static Stream DashboardLayoutGetir(int iDashboardID)
        {
            BarduckCRMEntities data = new BarduckCRMEntities();
            try
            {
                var List = data.S_Dashboard(iDashboardID,-1).ToList(); //MListler.MList_S_Dashboard.Where(u => u.ID == iDashboardID);
                if (List == null) return null;
                byte[] bLayout = null;
                bLayout = (byte[])List.FirstOrDefault().Layout;
                return Genel.ByteArrayToStream(bLayout);
            }
            catch (Exception exc)
            {
                return null;
            }
        }


        /// <summary>
        /// Dashboard formundaki layout ayarlarını kaydeder.
        /// </summary>
        public static byte[] DashboardLayoutToByte(int iDashboardID, DockManager dm)
        {
            System.IO.Stream str;
            str = new System.IO.MemoryStream();
            dm.SaveLayoutToStream(str);
            str.Seek(0, System.IO.SeekOrigin.Begin);
            byte[] Layout = Genel.StreamToByteArray(str);
            return Layout;
            //MListler.MList_S_Dashboard = Genel.PrmDb.S_Dashboard(0, Genel.DilID).ToList();
        }

        #endregion

        /// <summary>
        /// List değişkeni DataTable olarak dönderir.
        /// </summary>
        public static DataTable ListToDt<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                string sType = (prop.PropertyType).FullName.ToString();
                Type type = Type.GetType(sType);

                if (prop.PropertyType.FullName.ToString().Contains("System.Int32"))
                {
                    dataTable.Columns.Add(prop.Name, typeof(System.Int32));
                }
                else if (prop.PropertyType.FullName.ToString().Contains("System.Decimal"))
                {
                    dataTable.Columns.Add(prop.Name, typeof(System.Decimal));
                }
                else if (prop.PropertyType.FullName.ToString().Contains("System.Bool"))
                {
                    dataTable.Columns.Add(prop.Name, typeof(System.Boolean));
                }
                else if (type.Name == "Nullable`1")
                {
                    if (prop.Name.Contains("Tarih"))
                        dataTable.Columns.Add(prop.Name, typeof(System.DateTime));
                    else
                        dataTable.Columns.Add(prop.Name, typeof(System.Object));
                }
                else
                    dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            dataTable.AcceptChanges();
            return dataTable;
        }







    }

    class Mesaj
    {
        public enum MesajTipi
        {
            Uyari,
            Hata,
            Onay,
            Bilgi
        };
        public static Timer tmr = new Timer();
        public static AlertControl a;
        static void tmr_Tick(object sender, EventArgs e)
        {
            if (a.AlertFormList.Count > 0)
                a.AlertFormList[0].Close();

            tmr.Enabled = false;
        }

        public static void MesajVer(string Mesaj, MesajTipi Tip, XtraForm OwnerForm, int KacSaniye = 3)
        {
            a = new AlertControl();
            a.FormShowingEffect = AlertFormShowingEffect.SlideVertical;
            a.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            if (Tip == MesajTipi.Uyari)
                a.AppearanceText.ForeColor = Color.Blue;
            else if (Tip == MesajTipi.Hata)
                a.AppearanceText.ForeColor = Color.Red;

            a.ShowCloseButton = true;
            a.ShowPinButton = false;
            a.AllowHotTrack = false;

            Font fntBaslik = new Font("Arial", 8.3F, FontStyle.Bold | FontStyle.Underline);
            a.AppearanceCaption.Font = fntBaslik;
            Font fntText = new Font("Arial", 8, FontStyle.Regular);
            a.AppearanceText.Font = fntText;


            string Baslik = "";
            Image img = null;
            if (Tip == MesajTipi.Bilgi)
            {
                img = Resources.Info_32x32;
                Baslik = "Bilgi";
            }
            else if (Tip == MesajTipi.Hata)
            {
                img = Resources.Info_32x32;
                Baslik = "Hata";
            }
            else if (Tip == MesajTipi.Onay)
            {
                img = Resources.Info_32x32;
                Baslik = "Onay";
            }
            else if (Tip == MesajTipi.Uyari)
            {
                img = Resources.Info_32x32;
                Baslik = "Uyarı";
            }

            AlertInfo info = new AlertInfo(Baslik, Mesaj);
            info.Image = img;
            tmr.Tick += tmr_Tick;
            tmr.Interval = KacSaniye * 1000;
            tmr.Enabled = true;
            a.Show(OwnerForm, info);
        }

    }

 


}

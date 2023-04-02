using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarduckCRM;

namespace BarduckCRM
{
    class Data
    {
        public static BarduckCRMEntities DB = new BarduckCRMEntities();

        public static List<BarduckCRM.S_EsnekKayitQueryCalistir_Result> EsnekKayitlar(int QueryID, int KayitID)
        {
            List<BarduckCRM.S_EsnekKayitQueryCalistir_Result> list = new List<S_EsnekKayitQueryCalistir_Result>();
            string query = DB.S_EsnekKayitQuery(QueryID).FirstOrDefault().Query.Replace("#KayitID#", KayitID.ToString()).Replace("#DilID#", "1");
            if (query.Trim() != "")
                list = DB.S_EsnekKayitQueryCalistir(query, -1, -1).ToList();

            return list;
        }

        public static int EsnekKayitlarKaydet_checkedList(string SecilenKayitIDs, int KayitID, int QueryID)
        {
            try
            {
                var list = Data.DB.IUD_EsnekKayit(1, SecilenKayitIDs, KayitID, QueryID, 0, "", 0, null).ToList();
                return list.FirstOrDefault().Sonuc;
            }
            catch (Exception hata)
            {
                return -1;
            }
        }

        public static int EsnekKayitlarKaydet_grid(string SecilenKayitIDs, int KayitID, int QueryID, int iDeger, string nDeger, decimal dDeger, DateTime tDeger)
        {
            try
            {
                var list = Data.DB.IUD_EsnekKayit(2, SecilenKayitIDs, KayitID, QueryID, iDeger, nDeger, dDeger, tDeger).ToList();
                return list.FirstOrDefault().Sonuc;
            }
            catch (Exception hata)
            {
                return -1;
            }
        }







    }
}

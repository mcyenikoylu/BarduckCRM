//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarduckCRM
{
    using System;
    
    public partial class S_Vaziyet_Result
    {
        public int ID { get; set; }
        public Nullable<int> ProjeID { get; set; }
        public string Adres { get; set; }
        public Nullable<decimal> Metrekare { get; set; }
        public string PaftaNo { get; set; }
        public string CiltNo { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Koy { get; set; }
        public string Bucak { get; set; }
        public string Sokak { get; set; }
        public string AdaNo { get; set; }
        public string YevmiyeNo { get; set; }
        public string SahifeNo { get; set; }
        public string SiraNo { get; set; }
        public string HaritaEnlem { get; set; }
        public string HaritaBoylam { get; set; }
        public string VaziyetAdi { get; set; }
        public string VaziyetKodu { get; set; }
        public string YapiAdedi { get; set; }
        public string KapiAdedi { get; set; }
        public Nullable<decimal> YesilAlan { get; set; }
        public Nullable<int> VaziyetResimID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<bool> Sil { get; set; }
        public Nullable<System.DateTime> OlusturanTarih { get; set; }
        public Nullable<int> OlusturanKullaniciID { get; set; }
        public Nullable<System.DateTime> DegistirenTarih { get; set; }
        public Nullable<int> DegistirenKullaniciID { get; set; }
    }
}
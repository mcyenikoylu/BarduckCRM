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
    
    public partial class S_Ofis_Result
    {
        public int ID { get; set; }
        public string OfisAdi { get; set; }
        public string OfisKodu { get; set; }
        public Nullable<int> OlusturanKullaniciID { get; set; }
        public Nullable<System.DateTime> OlusturanTarih { get; set; }
        public Nullable<int> FirmaID { get; set; }
        public string FirmaAdi { get; set; }
        public Nullable<int> KarsilamaPersoneliID { get; set; }
        public string Adres { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<int> DegistirenKullaniciID { get; set; }
        public Nullable<System.DateTime> DegistirenTarih { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public Nullable<bool> Sil { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> UlkeID { get; set; }
        public Nullable<int> YetkiliPersonelID { get; set; }
    }
}
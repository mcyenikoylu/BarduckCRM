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
    
    public partial class S_Takim_Result
    {
        public int ID { get; set; }
        public string TakimKodu { get; set; }
        public string TakimAdi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<bool> Sil { get; set; }
        public Nullable<int> OlusturanKullaniciID { get; set; }
        public Nullable<System.DateTime> OlusturanKullaniciTarih { get; set; }
        public Nullable<int> DegistirenKullaniciID { get; set; }
        public Nullable<System.DateTime> DegistirenKullaniciTarih { get; set; }
    }
}
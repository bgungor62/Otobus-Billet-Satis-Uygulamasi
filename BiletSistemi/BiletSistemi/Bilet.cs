//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiletSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilet
    {
        public int id { get; set; }
        public int SeferId { get; set; }
        public byte KoltukNo { get; set; }
        public string YolcuAd { get; set; }
        public string YolcuSoyad { get; set; }
        public string YolcuTel { get; set; }
        public string YolcuCinsiyet { get; set; }
        public decimal Ucret { get; set; }
        public string VarisDurak { get; set; }
        public string UcretTip { get; set; }
        public Nullable<System.DateTime> IslemTarih { get; set; }
        public Nullable<bool> Silme { get; set; }
    
        public virtual Sefer Sefer { get; set; }
    }
}

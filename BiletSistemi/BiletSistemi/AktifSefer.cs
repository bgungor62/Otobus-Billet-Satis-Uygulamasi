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
    
    public partial class AktifSefer
    {
        public int Id { get; set; }
        public int SeferId { get; set; }
        public Nullable<bool> Silme { get; set; }
    
        public virtual Sefer Sefer { get; set; }
    }
}

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
    
    public partial class Sehir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sehir()
        {
            this.Sefer = new HashSet<Sefer>();
            this.Sefer1 = new HashSet<Sefer>();
        }
    
        public int id { get; set; }
        public string SehirAd { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sefer> Sefer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sefer> Sefer1 { get; set; }
    }
}

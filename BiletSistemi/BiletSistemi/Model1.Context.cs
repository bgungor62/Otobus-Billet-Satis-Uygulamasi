﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtobusBiletEntities3 : DbContext
    {
        public OtobusBiletEntities3()
            : base("name=OtobusBiletEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<AktifSefer> AktifSefer { get; set; }
        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Kaptan> Kaptan { get; set; }
        public virtual DbSet<Muavin> Muavin { get; set; }
        public virtual DbSet<Otobus> Otobus { get; set; }
        public virtual DbSet<Sefer> Sefer { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<Yolcu> Yolcu { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kampiraliste
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KampiralisteEntiteti : DbContext
    {
        public KampiralisteEntiteti()
            : base("name=KampiralisteEntiteti")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<drzava> drzavas { get; set; }
        public virtual DbSet<gost> gosts { get; set; }
        public virtual DbSet<parcela> parcelas { get; set; }
        public virtual DbSet<prijava> prijavas { get; set; }
        public virtual DbSet<smjestaj> smjestajs { get; set; }
        public virtual DbSet<vrsta_dokumenta> vrsta_dokumenta { get; set; }
        public virtual DbSet<vrsta_smjestaja> vrsta_smjestaja { get; set; }
        public virtual DbSet<zaposlenik> zaposleniks { get; set; }
        public virtual DbSet<status_osobe> status_osobe { get; set; }
        public virtual DbSet<racun> racuns { get; set; }
    }
}

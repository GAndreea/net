﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BTESTEntities1 : DbContext
    {
        public BTESTEntities1()
            : base("name=BTESTEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AUTOR> AUTOR { get; set; }
        public virtual DbSet<CARTE> CARTE { get; set; }
        public virtual DbSet<CITITOR> CITITOR { get; set; }
        public virtual DbSet<GEN> GEN { get; set; }
        public virtual DbSet<IMPRUMUT> IMPRUMUT { get; set; }
        public virtual DbSet<REVIEW> REVIEW { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}

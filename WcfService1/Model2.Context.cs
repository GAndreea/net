﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BTESTEntities : DbContext
    {
        public BTESTEntities()
            : base("name=BTESTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AUTOR> AUTORs { get; set; }
        public DbSet<CARTE> CARTEs { get; set; }
        public DbSet<CITITOR> CITITORs { get; set; }
        public DbSet<GEN> GENs { get; set; }
        public DbSet<IMPRUMUT> IMPRUMUTs { get; set; }
        public DbSet<REVIEW> REVIEWs { get; set; }
    }
}

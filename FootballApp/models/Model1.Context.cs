﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballApp.models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FootballProjectEntities : DbContext
    {
        public FootballProjectEntities()
            : base("name=FootballProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer_To_Stadion> Customer_To_Stadion { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Rezerv> Rezervs { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Stadion> Stadions { get; set; }
    }
}

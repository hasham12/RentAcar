﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class carProjectEntities : DbContext
    {
        public carProjectEntities()
            : base("name=carProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CarInfo> CarInfoes { get; set; }
        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<DriverInfo> DriverInfoes { get; set; }
        public DbSet<PickLocation> PickLocations { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}

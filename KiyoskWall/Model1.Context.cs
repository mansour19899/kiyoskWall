﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiyoskWall
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoonehEntities : DbContext
    {
        public PoonehEntities()
            : base("name=PoonehEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PoonehReservation> PoonehReservations { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Tray> Trays { get; set; }
        public virtual DbSet<WorkSheet> WorkSheets { get; set; }
        public virtual DbSet<HoliDay> HoliDays { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<agent> agents { get; set; }
        public virtual DbSet<apartment_demands> apartment_demands { get; set; }
        public virtual DbSet<apartment> apartments { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<house_demands> house_demands { get; set; }
        public virtual DbSet<house> houses { get; set; }
        public virtual DbSet<land_demands> land_demands { get; set; }
        public virtual DbSet<land> lands { get; set; }
        public virtual DbSet<supply> supplies { get; set; }
    }
}
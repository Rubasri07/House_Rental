﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace House_Rental_System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class House_Rental : DbContext
    {
        public House_Rental()
            : base("name=House_Rental")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking_Details> Booking_Details { get; set; }
        public virtual DbSet<Customer_Details> Customer_Details { get; set; }
        public virtual DbSet<Property_Details> Property_Details { get; set; }
        public virtual DbSet<Property_Images> Property_Images { get; set; }
        public virtual DbSet<Property_Information> Property_Information { get; set; }
        public virtual DbSet<Seller_Details> Seller_Details { get; set; }
        public virtual DbSet<Sold_Property> Sold_Property { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TirleaPaul2022
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TirleaPaul2022Context : DbContext
    {
        public TirleaPaul2022Context()
            : base("name=TirleaPaul2022Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<View_Orders_20> View_Orders_20 { get; set; }
        public virtual DbSet<View_Orders_21> View_Orders_21 { get; set; }
        public virtual DbSet<View_Orders_22> View_Orders_22 { get; set; }
        public virtual DbSet<View_Orders_By_Category> View_Orders_By_Category { get; set; }
        public virtual DbSet<View_Products_In_Stock> View_Products_In_Stock { get; set; }
        public virtual DbSet<View_Sales_Value> View_Sales_Value { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebSeriesDBEntities : DbContext
    {
        public WebSeriesDBEntities()
            : base("name=WebSeriesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<Expans> Expanses { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Mywatchlist> Mywatchlists { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Salary> Salarys { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<UserReview> UserReviews { get; set; }
    }
}

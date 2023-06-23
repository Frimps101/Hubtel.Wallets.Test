using Hubtel.Wallets.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Persistence.Data
{
    public class HubtelDbContext:DbContext
    {
        public HubtelDbContext(DbContextOptions<HubtelDbContext> options):base(options)
        {
                
        }

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<AccountScheme> AccountSchemes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wallet>().ToTable("Wallet");
            modelBuilder.Entity<PaymentType>().ToTable("PaymentType");
            modelBuilder.Entity<AccountScheme>().ToTable("AccountScheme");
        }
    }
}

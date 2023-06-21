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
    }
}

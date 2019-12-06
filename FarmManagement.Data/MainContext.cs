using System;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        public DbSet<Cattle> Cattles { get; set; }
        public DbSet<FinancialAsset> FinancialAssets { get; set; }
        
    }
}

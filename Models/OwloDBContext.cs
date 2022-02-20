using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OwlOProjectA.Models
{
    public class OwloDBContext : DbContext
    {
        private readonly IConfiguration _config;
        public OwloDBContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _config.GetConnectionString("MyConn");
            optionsBuilder.UseSqlServer(connectionString);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Owlee>()
        //        .Property(p => p.Inventory_ID)
        //        .ValueGeneratedOnAdd()
        //        .UseIdentityColumn();
        //}

        public DbSet<Owlee> Owlees { get; set; }

        public DbSet<Voucher> Vouchers { get; set; }

        public DbSet<LuckyDraw> LuckyDraws { get; set; }

        public DbSet<FAQ> FAQs { get; set; }

        public DbSet<VoucherDistribution> VoucherDistributions { get; set; }

        public DbSet<Workshop> Workshop { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Venue> Venues { get; set; }
    }
}

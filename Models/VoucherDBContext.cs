using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class VoucherDBContext : DbContext
    {
        private readonly IConfiguration _config;
        public VoucherDBContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _config.GetConnectionString("VoucherConn");
            optionsBuilder.UseSqlServer(connectionString);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Owlee>()
        //        .Property(p => p.Inventory_ID)
        //        .ValueGeneratedOnAdd()
        //        .UseIdentityColumn();
        //}

        public DbSet<Voucher> Vouchers { get; set; }
    }
}

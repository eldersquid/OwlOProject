using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
namespace owlo_plan.Models
{
    public class OwloPlanDBContext : DbContext
    {
        private readonly IConfiguration _config;
        public OwloPlanDBContext(DbContextOptions<OwloPlanDBContext> options, IConfiguration configuration) : base(options) 
        {
            _config = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Get connection string from the value of "MyConn" in appsettings and  
                // configure context to connect to microsoft sql server database
                string connectionString = _config.GetConnectionString("MyConn");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        //tables in the database
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Owlers> Owlers { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<SkillsNeeded> SkillsNeeded { get; set; }
        public virtual DbSet<CommunityPartners> CommunityPartners { get; set; }
        public virtual DbSet<Causes> Causes { get; set; }
        public virtual DbSet<TeamMembers> TeamMembers { get; set; }
        public virtual DbSet<ProjectTasks> ProjectTasks { get; set; }
        public virtual DbSet<JoinRequests> JoinRequests { get; set; }

        public virtual DbSet<userSkills> userSkills { get; set; }
        public virtual DbSet<userInterests> userInterests { get; set; }

    }
}

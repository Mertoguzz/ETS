using ETS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace ETS.API.DBContext
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration configuration;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        #region PostgreSQL Configuration
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseNpgsql("Host=localhost;Database=ETSDB;Username=mert;Password=1234");
        //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseNpgsql(Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(configuration, "ETSDB")); 
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = new Guid(),
                    Name = "Mert",
                    Surname = "OĞUZ",
                    Address = "mertoguz Adresi",
                    BloodGroup = "A RH -",
                    Phone = "5052673758"
                },
                new User
                {
                    ID = new Guid(),
                    Name = "123Mert",
                    Surname = "OĞUZ",
                    Address = "1234mertoguz Adresi",
                    BloodGroup = "B RH -",
                    Phone = "50526737501}"
                }
                );
        }

        public DbSet<User> Users { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "India",
                    ShortName = "Ind"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "England",
                    ShortName = "Eng"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "Australia",
                    ShortName = "Aus"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj Hotel",
                    Address = "India Gate, Mumbai",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Chalet",
                    Address = "Australia",
                    Rating = 4,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Great England Hotel",
                    Address = "Lords",
                    Rating = 3,
                    CountryId = 2
                }
            );
        }

    }
}

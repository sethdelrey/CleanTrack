using CleanTrack.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CleanTrack.Data
{
    public class SuppliesContext : DbContext
    {
        public DbSet<SupplyItem> Supplies { get; set; }

        public SuppliesContext(DbContextOptions<SuppliesContext> options)
            : base(options)
        { }

        public SuppliesContext()
            : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CleanTrack;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplyItem>()
                .HasKey(si => si.Name);

            var supplies = new[]
            {
                new SupplyItem
                {
                    Name = "Trash Bags",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Mopping Solution",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Hand Towels",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Paper Towles",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Duster Replacements",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Window Cleaner",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Pumice Stone",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Toilet Bowl Cleaner",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "All Purpose Cleaner",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Mop",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Dust Mop",
                    OutOf = false
                },
                new SupplyItem
                {
                    Name = "Vacuum",
                    OutOf = false
                }
            };

            modelBuilder.Entity<SupplyItem>().HasData(supplies);

            base.OnModelCreating(modelBuilder);
        }
    }
}

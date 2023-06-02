using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Lasmart.Services;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Point> Points { get; set; }
    }
}
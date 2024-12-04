using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceApp
{
    public class EmployeeAppContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Developer> Developers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=3-0;Initial Catalog=ado_db;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            //            .UseTptMappingStrategy();
            //            .UseTphMappingStrategy();
                        .UseTpcMappingStrategy();

            // tpt
            //modelBuilder.Entity<Manager>().ToTable("Managers");
            //modelBuilder.Entity<Developer>().ToTable("Developers");
        }
    }
}

using EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Context
{
    internal class EventContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDB;Trusted_Connection=true;TrustServerCertificate=true");
              



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // modelBuilder.Entity<Badge>().Property(B => B.IssueDate).HasComputedColumnSql();
        }
        DbSet<EventOrganizers> EventOrganizers { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerActivityProject.DAL.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Festival> Festivals  { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
    }
}

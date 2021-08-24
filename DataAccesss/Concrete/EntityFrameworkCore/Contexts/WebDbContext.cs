using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesss.Concrete.EntityFrameworkCore.Contexts
{
   public class WebDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }


        public DbSet<Home> Settings { get; set; }
        public DbSet<HomeLang> SocialMedias { get; set; }
      
    }
}

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
            optionsBuilder.UseSqlServer(@"Data Source=94.73.170.2; Initial Catalog=u9888118_radyogr; Persist Security Info=True; User ID=u9888118_radyogr; Password=RTfr49U3KNrw41A;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }


        public DbSet<Home> Settings { get; set; }
        public DbSet<HomeLang> SocialMedias { get; set; }
      
    }
}

using Microsoft.EntityFrameworkCore;
using PhotoGallary_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallary_Reopsitary.Context
{
    public class PhotoGallaryDbContext:DbContext
    {
        public PhotoGallaryDbContext(DbContextOptions<PhotoGallaryDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<User> Users { get; set; }  
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Gallary> Gallaries { get; set; }
    }
}

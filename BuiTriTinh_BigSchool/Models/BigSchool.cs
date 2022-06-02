using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BuiTriTinh_BigSchool.Models
{
    public partial class BigSchool : DbContext
    {
        public BigSchool()
            : base("name=BigSchoolContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOptional(e => e.Course)
                .WithRequired(e => e.Category)
        }
    }
}

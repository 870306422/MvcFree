using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MvcFr.Models
{
    public partial class Student3 : DbContext
    {
        public Student3()
            : base("name=Student31")
        {
        }

        public virtual DbSet<classes> classes { get; set; }
        public virtual DbSet<logen> logen { get; set; }
        public virtual DbSet<stuinfo> stuinfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<classes>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<classes>()
                .HasMany(e => e.stuinfo)
                .WithRequired(e => e.classes)
                .HasForeignKey(e => e.ClassId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<logen>()
                .Property(e => e.loge)
                .IsUnicode(false);

            modelBuilder.Entity<logen>()
                .Property(e => e.pwd)
                .IsUnicode(false);

            modelBuilder.Entity<stuinfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<stuinfo>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<stuinfo>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}

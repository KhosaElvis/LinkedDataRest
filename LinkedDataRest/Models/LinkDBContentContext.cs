using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LinkedDataRest.Models
{
    public partial class LinkDBContentContext : DbContext
    {
        public virtual DbSet<TblPerson> TblPerson { get; set; }

        public LinkDBContentContext(DbContextOptions<LinkDBContentContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblPerson>(entity =>
            {
                entity.ToTable("tblPERSON");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
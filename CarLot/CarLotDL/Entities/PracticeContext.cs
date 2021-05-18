using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CarLotDL.Entities
{
    public partial class PracticeContext : DbContext
    {
        public PracticeContext()
        {
        }

        public PracticeContext(DbContextOptions<PracticeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            
            modelBuilder.Entity<Car>(entity =>
            {
            entity.ToTable("restaurants");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Year)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("city");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.Property(e => e.Mpg)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("state");
            });

            modelBuilder.Entity<Description>(entity =>
            {
            entity.ToTable("reviews");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Mpg)
                .IsRequired()
                .HasMaxLength(240)
                .HasColumnName("description");

            entity.Property(e => e.Year).HasColumnName("rating");

            entity.Property(e => e.CarId).HasColumnName("restaurantID");

            entity.HasOne(d => d.Car)
                .WithMany(p => p.Descriptions)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__reviews__restaur__6D0D32F4");
            });



            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

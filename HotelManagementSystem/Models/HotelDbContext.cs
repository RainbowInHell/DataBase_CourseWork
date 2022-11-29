using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotelManagementSystem.Models
{
    public partial class HotelDbContext : DbContext
    {
        public HotelDbContext()
        {
        }

        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=HotelDb;uid=root;pwd=matvey2003", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admins");

                entity.Property(e => e.AdminPassword).HasMaxLength(25);

                entity.Property(e => e.AdminUserName).HasMaxLength(25);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.HasIndex(e => e.HotelId, "HotelId");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(200);

                entity.Property(e => e.DepartmentName).HasMaxLength(20);

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("departments_ibfk_1");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("hotels");

                entity.HasIndex(e => e.HotelAddress, "HotelAddress")
                    .IsUnique();

                entity.HasIndex(e => e.HotelContactNumber, "HotelContactNumber")
                    .IsUnique();

                entity.HasIndex(e => e.HotelEmail, "HotelEmail")
                    .IsUnique();

                entity.HasIndex(e => e.HotelName, "HotelName")
                    .IsUnique();

                entity.HasIndex(e => e.HotelWebsite, "HotelWebsite")
                    .IsUnique();

                entity.Property(e => e.HotelAddress).HasMaxLength(30);

                entity.Property(e => e.HotelCity).HasMaxLength(20);

                entity.Property(e => e.HotelContactNumber).HasMaxLength(15);

                entity.Property(e => e.HotelCountry).HasMaxLength(20);

                entity.Property(e => e.HotelDescription).HasMaxLength(200);

                entity.Property(e => e.HotelEmail).HasMaxLength(30);

                entity.Property(e => e.HotelName).HasMaxLength(30);

                entity.Property(e => e.HotelWebsite).HasMaxLength(30);

                entity.Property(e => e.HotelZip).HasMaxLength(5);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

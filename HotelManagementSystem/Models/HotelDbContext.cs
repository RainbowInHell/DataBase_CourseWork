using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Models;

public partial class HotelDbContext : DbContext
{
    public HotelDbContext()
    {
    }

    public HotelDbContext(DbContextOptions<HotelDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=D:\\College_Of_Business_and_Law(2019-2023)\\BD_AND_SUBD\\CourseWork\\Hotel_Management_System\\HotelManagementSystem\\DataBaseSourceFile\\HotelDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasOne(d => d.Hotel).WithMany(p => p.Departments)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasIndex(e => e.HotelAddress, "IX_Hotels_HotelAddress").IsUnique();

            entity.HasIndex(e => e.HotelContactNumber, "IX_Hotels_HotelContactNumber").IsUnique();

            entity.HasIndex(e => e.HotelEmail, "IX_Hotels_HotelEmail").IsUnique();

            entity.HasIndex(e => e.HotelName, "IX_Hotels_HotelName").IsUnique();

            entity.HasIndex(e => e.HotelWebsite, "IX_Hotels_HotelWebsite").IsUnique();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

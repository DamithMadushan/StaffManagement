using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SM.Infrastructure.Persistance.Models;

public partial class StaffManagementDBContext : DbContext
{
    public StaffManagementDBContext()
    {
    }

    public StaffManagementDBContext(DbContextOptions<StaffManagementDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffType> StaffTypes { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2GFIBDD;Database=StaffManagement;Trusted_Connection=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.Irdnumber)
                .HasMaxLength(150)
                .HasColumnName("IRDNumber");
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.MiddleInitial).HasMaxLength(50);
            entity.Property(e => e.OfficeExtention).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.StaffTypeId).HasColumnName("StaffTypeID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK_Staff_Staff1");

            entity.HasOne(d => d.StaffType).WithMany(p => p.Staff)
                .HasForeignKey(d => d.StaffTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Staff_StaffType");

            entity.HasOne(d => d.Status).WithMany(p => p.Staff)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Staff_Status");

            entity.HasOne(d => d.Title).WithMany(p => p.Staff)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Staff_Title");
        });

        modelBuilder.Entity<StaffType>(entity =>
        {
            entity.ToTable("StaffType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Status1)
                .HasMaxLength(50)
                .HasColumnName("Status");
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.ToTable("Title");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Title1)
                .HasMaxLength(50)
                .HasColumnName("Title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

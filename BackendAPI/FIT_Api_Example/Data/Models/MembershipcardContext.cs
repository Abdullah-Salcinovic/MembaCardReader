using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.Data.Models
{
    public partial class MembershipcardContext : DbContext
    {
        public MembershipcardContext()
        {
        }

        public MembershipcardContext(DbContextOptions<MembershipcardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Resource> Resources { get; set; } = null!;
        public virtual DbSet<Rfidscan> Rfidscans { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q0I34LS;Initial Catalog=Membershipcard;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.Cncmill)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("CNCMill")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.LaserCutter)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PremiumFilament).HasDefaultValueSql("((0))");

                entity.Property(e => e.QualifiedForLcdprinters).HasColumnName("QualifiedForLCDPrinters");

                entity.Property(e => e.Resin).HasDefaultValueSql("((0))");

                entity.Property(e => e.StandardFilament).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Resources__UserI__6383C8BA");
            });

            modelBuilder.Entity<Rfidscan>(entity =>
            {
                entity.HasKey(e => e.ScanId)
                    .HasName("PK__RFIDScan__63B32661741097FA");

                entity.ToTable("RFIDScans");

                entity.Property(e => e.ScanId).HasColumnName("ScanID");

                entity.Property(e => e.Rfidcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RFIDCode");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rfidscans)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__RFIDScans__UserI__66603565");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidUntil).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

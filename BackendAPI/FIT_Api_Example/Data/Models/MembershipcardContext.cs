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

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<Membership> Memberships { get; set; } = null!;

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
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasMany(d => d.Materials)
                    .WithMany(p => p.Customers)
                    .UsingEntity<Dictionary<string, object>>(
                        "CustomerMaterial",
                        l => l.HasOne<Material>().WithMany().HasForeignKey("MaterialId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__CUSTOMER___Mater__2C3393D0"),
                        r => r.HasOne<Customer>().WithMany().HasForeignKey("CustomerId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__CUSTOMER___Custo__2B3F6F97"),
                        j =>
                        {
                            j.HasKey("CustomerId", "MaterialId").HasName("PK__CUSTOMER__4F121DB65D928B2E");

                            j.ToTable("CUSTOMER_MATERIAL");

                            j.IndexerProperty<string>("CustomerId").HasMaxLength(20).IsUnicode(false).HasColumnName("Customer_ID");

                            j.IndexerProperty<int>("MaterialId").HasColumnName("Material_ID");
                        });
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("MATERIAL");

                entity.Property(e => e.MaterialId)
                    .ValueGeneratedNever()
                    .HasColumnName("Material_ID");

                entity.Property(e => e.Cncmill)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CNCMill");

                entity.Property(e => e.Filament)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LaserCutter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumFilament)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Resin)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.ToTable("MEMBERSHIP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("Expiration_Date");

                entity.Property(e => e.Lcdprinters).HasColumnName("LCDPrinters");

                entity.Property(e => e.Subscription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Memberships)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__MEMBERSHI__Custo__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

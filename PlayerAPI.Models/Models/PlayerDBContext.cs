using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PlayerAPI.API.Models
{
    public partial class PlayerDBContext : DbContext
    {
        public PlayerDBContext()
        {
        }

        public PlayerDBContext(DbContextOptions<PlayerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<PlayerMaster> PlayerMasters { get; set; }
        public virtual DbSet<PlayerTypeMaster> PlayerTypeMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=LAPTOP-FACC1M3K\\SQLEXPRESS;Trusted_Connection=True;;Database=PlayerDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("CountryMaster");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedNever()
                    .HasColumnName("countryId");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("country");
            });

            modelBuilder.Entity<PlayerMaster>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("PlayerMaster");

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.PlayerBmi).HasColumnName("playerBMI");

                entity.Property(e => e.PlayerCountry).HasColumnName("playerCountry");

                entity.Property(e => e.PlayerHeight)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("playerHeight");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("playerName");

                entity.Property(e => e.PlayerRuns).HasColumnName("playerRuns");

                entity.Property(e => e.PlayerStumpings).HasColumnName("playerStumpings");

                entity.Property(e => e.PlayerType).HasColumnName("playerType");

                entity.Property(e => e.PlayerWickets).HasColumnName("playerWickets");

                entity.HasOne(d => d.PlayerCountryNavigation)
                    .WithMany(p => p.PlayerMasters)
                    .HasForeignKey(d => d.PlayerCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlayerMas__playe__37A5467C");

                entity.HasOne(d => d.PlayerTypeNavigation)
                    .WithMany(p => p.PlayerMasters)
                    .HasForeignKey(d => d.PlayerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlayerMas__playe__36B12243");
            });

            modelBuilder.Entity<PlayerTypeMaster>(entity =>
            {
                entity.HasKey(e => e.PlayerTypeId);

                entity.ToTable("PlayerTypeMaster");

                entity.Property(e => e.PlayerTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("playerTypeId");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

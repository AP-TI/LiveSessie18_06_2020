using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFTest.Models
{
    public partial class TennisContext : DbContext
    {
        public TennisContext()
        {
        }

        public TennisContext(DbContextOptions<TennisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bestuursleden> Bestuursleden { get; set; }
        public virtual DbSet<Boetes> Boetes { get; set; }
        public virtual DbSet<Spelers> Spelers { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Wedstrijden> Wedstrijden { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QFF0ENQ\\SQLEXPRESS;Initial Catalog=Tennis;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bestuursleden>(entity =>
            {
                entity.HasKey(e => new { e.Spelersnr, e.BeginDatum })
                    .HasName("PK__BESTUURS__06B2A82C5B9CBE9B");

                entity.ToTable("BESTUURSLEDEN");

                entity.Property(e => e.Spelersnr).HasColumnName("SPELERSNR");

                entity.Property(e => e.BeginDatum)
                    .HasColumnName("BEGIN_DATUM")
                    .HasColumnType("date");

                entity.Property(e => e.EindDatum)
                    .HasColumnName("EIND_DATUM")
                    .HasColumnType("date");

                entity.Property(e => e.Functie)
                    .HasColumnName("FUNCTIE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.SpelersnrNavigation)
                    .WithMany(p => p.Bestuursleden)
                    .HasForeignKey(d => d.Spelersnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BESTUURSL__SPELE__2C3393D0");
            });

            modelBuilder.Entity<Boetes>(entity =>
            {
                entity.HasKey(e => e.Betalingsnr)
                    .HasName("PK__BOETES__F4C83DEAFB853447");

                entity.ToTable("BOETES");

                entity.Property(e => e.Betalingsnr)
                    .HasColumnName("BETALINGSNR")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bedrag)
                    .HasColumnName("BEDRAG")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Datum)
                    .HasColumnName("DATUM")
                    .HasColumnType("date");

                entity.Property(e => e.Spelersnr).HasColumnName("SPELERSNR");

                entity.HasOne(d => d.SpelersnrNavigation)
                    .WithMany(p => p.Boetes)
                    .HasForeignKey(d => d.Spelersnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOETES__SPELERSN__2D27B809");
            });

            modelBuilder.Entity<Spelers>(entity =>
            {
                entity.HasKey(e => e.Spelersnr)
                    .HasName("PK__SPELERS__77B1075926287D77");

                entity.ToTable("SPELERS");

                entity.Property(e => e.Spelersnr)
                    .HasColumnName("SPELERSNR")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bondsnr)
                    .HasColumnName("BONDSNR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GebDatum)
                    .HasColumnName("GEB_DATUM")
                    .HasColumnType("date");

                entity.Property(e => e.Geslacht)
                    .IsRequired()
                    .HasColumnName("GESLACHT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Huisnr)
                    .HasColumnName("HUISNR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jaartoe).HasColumnName("JAARTOE");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Plaats)
                    .IsRequired()
                    .HasColumnName("PLAATS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Straat)
                    .IsRequired()
                    .HasColumnName("STRAAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefoon)
                    .HasColumnName("TELEFOON")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Voorletters)
                    .IsRequired()
                    .HasColumnName("VOORLETTERS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.Teamnr)
                    .HasName("PK__TEAMS__966C64C3B9E305EF");

                entity.ToTable("TEAMS");

                entity.Property(e => e.Teamnr)
                    .HasColumnName("TEAMNR")
                    .ValueGeneratedNever();

                entity.Property(e => e.Divisie)
                    .IsRequired()
                    .HasColumnName("DIVISIE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spelersnr).HasColumnName("SPELERSNR");

                entity.HasOne(d => d.SpelersnrNavigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.Spelersnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TEAMS__SPELERSNR__2E1BDC42");
            });

            modelBuilder.Entity<Wedstrijden>(entity =>
            {
                entity.HasKey(e => e.Wedstrijdnr)
                    .HasName("PK__WEDSTRIJ__B5B27259BCE822AB");

                entity.ToTable("WEDSTRIJDEN");

                entity.Property(e => e.Wedstrijdnr)
                    .HasColumnName("WEDSTRIJDNR")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gewonnen).HasColumnName("GEWONNEN");

                entity.Property(e => e.Spelersnr).HasColumnName("SPELERSNR");

                entity.Property(e => e.Teamnr).HasColumnName("TEAMNR");

                entity.Property(e => e.Verloren).HasColumnName("VERLOREN");

                entity.HasOne(d => d.SpelersnrNavigation)
                    .WithMany(p => p.Wedstrijden)
                    .HasForeignKey(d => d.Spelersnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WEDSTRIJD__SPELE__2F10007B");

                entity.HasOne(d => d.TeamnrNavigation)
                    .WithMany(p => p.Wedstrijden)
                    .HasForeignKey(d => d.Teamnr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WEDSTRIJD__TEAMN__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

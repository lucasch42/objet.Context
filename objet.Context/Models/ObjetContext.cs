using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace objet.Context.Models;

public partial class ObjetContext : DbContext
{
    public ObjetContext()
    {
    }

    public ObjetContext(DbContextOptions<ObjetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Entreprise> Entreprises { get; set; }

    public virtual DbSet<Lieu> Lieus { get; set; }

    public virtual DbSet<ObjetTrouve> ObjetTrouves { get; set; }

    public virtual DbSet<Salarie> Salaries { get; set; }

    public virtual DbSet<Usager> Usagers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-AQNB9OT\\SQLEXPRESS;Database=objet;Integrated Security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.Categorieid).HasName("PK__Categori__60A18CB46FAA8951");

            entity.ToTable("Categorie");

            entity.Property(e => e.Categorieid).HasColumnName("categorieid");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Entreprise>(entity =>
        {
            entity.HasKey(e => e.Entrepriseid).HasName("PK__Entrepri__A554B45F7FE5CF6C");

            entity.ToTable("Entreprise");

            entity.Property(e => e.Entrepriseid).HasColumnName("entrepriseid");
            entity.Property(e => e.Adresse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.Codepostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codepostal");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Numerosiret)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numerosiret");
            entity.Property(e => e.Pays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pays");
            entity.Property(e => e.Ville)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ville");
        });

        modelBuilder.Entity<Lieu>(entity =>
        {
            entity.HasKey(e => e.Lieuxid).HasName("PK__Lieu__B24E8454B2AB9823");

            entity.ToTable("Lieu");

            entity.Property(e => e.Lieuxid).HasColumnName("lieuxid");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Entrepriseid).HasColumnName("entrepriseid");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");

            entity.HasOne(d => d.Entreprise).WithMany(p => p.Lieus)
                .HasForeignKey(d => d.Entrepriseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Lieu__entreprise__398D8EEE");
        });

        modelBuilder.Entity<ObjetTrouve>(entity =>
        {
            entity.HasKey(e => e.Objetid).HasName("PK__ObjetTro__0A1B7B6FD47AAC45");

            entity.ToTable("ObjetTrouve");

            entity.Property(e => e.Objetid).HasColumnName("objetid");
            entity.Property(e => e.Categorieid).HasColumnName("categorieid");
            entity.Property(e => e.Couleur)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("couleur");
            entity.Property(e => e.Datedecouverte)
                .HasColumnType("datetime")
                .HasColumnName("datedecouverte");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Lieuxid).HasColumnName("lieuxid");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Numeroserie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroserie");
            entity.Property(e => e.Salarieid).HasColumnName("salarieid");
            entity.Property(e => e.Usagerid).HasColumnName("usagerid");

            entity.HasOne(d => d.Categorie).WithMany(p => p.ObjetTrouves)
                .HasForeignKey(d => d.Categorieid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ObjetTrou__categ__440B1D61");

            entity.HasOne(d => d.Lieux).WithMany(p => p.ObjetTrouves)
                .HasForeignKey(d => d.Lieuxid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ObjetTrou__lieux__44FF419A");

            entity.HasOne(d => d.Salarie).WithMany(p => p.ObjetTrouves)
                .HasForeignKey(d => d.Salarieid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ObjetTrou__salar__4316F928");

            entity.HasOne(d => d.Usager).WithMany(p => p.ObjetTrouves)
                .HasForeignKey(d => d.Usagerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ObjetTrou__usage__45F365D3");
        });

        modelBuilder.Entity<Salarie>(entity =>
        {
            entity.HasKey(e => e.Salarieid).HasName("PK__Salarie__222F82C5F05E6262");

            entity.ToTable("Salarie");

            entity.Property(e => e.Salarieid).HasColumnName("salarieid");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Entrepriseid).HasColumnName("entrepriseid");
            entity.Property(e => e.Motdepasse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("motdepasse");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");

            entity.HasOne(d => d.Entreprise).WithMany(p => p.Salaries)
                .HasForeignKey(d => d.Entrepriseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Salarie__entrepr__3E52440B");
        });

        modelBuilder.Entity<Usager>(entity =>
        {
            entity.HasKey(e => e.Usagerid).HasName("PK__Usager__B5E8521F6909DD76");

            entity.ToTable("Usager");

            entity.Property(e => e.Usagerid).HasColumnName("usagerid");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Motdepasse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motdepasse");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace waAlquimia.Models;

public partial class DbAlquimiaContext : DbContext
{
    public DbAlquimiaContext()
    {
    }

    public DbAlquimiaContext(DbContextOptions<DbAlquimiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administracion> Administracions { get; set; }

    public virtual DbSet<Bebida> Bebidas { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Platillo> Platillos { get; set; }

    public virtual DbSet<Postre> Postres { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-4ATTP8GE;Database=dbAlquimia;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administracion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Administ__3214EC2797BDFAF8");

            entity.ToTable("Administracion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rol)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bebida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bebidas__3214EC27D2A9502E");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Menu__3214EC27DB791E58");

            entity.ToTable("Menu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BebidaId).HasColumnName("BebidaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PlatilloId).HasColumnName("PlatilloID");
            entity.Property(e => e.PostreId).HasColumnName("PostreID");

            entity.HasOne(d => d.Bebida).WithMany(p => p.Menus)
                .HasForeignKey(d => d.BebidaId)
                .HasConstraintName("FK__Menu__BebidaID__440B1D61");

            entity.HasOne(d => d.Platillo).WithMany(p => p.Menus)
                .HasForeignKey(d => d.PlatilloId)
                .HasConstraintName("FK__Menu__PlatilloID__4316F928");

            entity.HasOne(d => d.Postre).WithMany(p => p.Menus)
                .HasForeignKey(d => d.PostreId)
                .HasConstraintName("FK__Menu__PostreID__44FF419A");
        });

        modelBuilder.Entity<Platillo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Platillo__3214EC277365D77B");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<Postre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Postres__3214EC27BF205E3E");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservas__3214EC27C89BF8EF");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaReserva).HasColumnType("date");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC270118FDB4");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

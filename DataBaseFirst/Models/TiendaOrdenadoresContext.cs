using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Models;

public partial class TiendaOrdenadoresContext : DbContext
{
    public TiendaOrdenadoresContext()
    {
    }

    public TiendaOrdenadoresContext(DbContextOptions<TiendaOrdenadoresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Componente> Componentes { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Ordenador> Ordenadors { get; set; }

    public virtual DbSet<OrdenadorComponente> OrdenadorComponentes { get; set; }

    public virtual DbSet<OrdenadoresFactura> OrdenadoresFacturas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\PruebaComponentesObdulio\\DataBaseFirst\\Data\\TiendaOrdenadores.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Componente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Componen__3214EC079F9FA03D");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Coste).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.ToTable("Factura");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CalorTotal).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.PrecioTotal).HasColumnType("numeric(18, 10)");
        });

        modelBuilder.Entity<Ordenador>(entity =>
        {
            entity.ToTable("Ordenador");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PrecioTotal).HasColumnType("numeric(18, 10)");
        });

        modelBuilder.Entity<OrdenadorComponente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrdenadorComponente", tb => tb.HasTrigger("UpdateOrdenadorTotals"));

            entity.HasOne(d => d.ComponenteNavigation).WithMany()
                .HasForeignKey(d => d.Componente)
                .HasConstraintName("FK_OrdenadorComponente_Componente");

            entity.HasOne(d => d.OrdenadorNavigation).WithMany()
                .HasForeignKey(d => d.Ordenador)
                .HasConstraintName("FK_OrdenadorComponente_Ordenador");
        });

        modelBuilder.Entity<OrdenadoresFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("UpdateFacturaTotals"));

            entity.HasOne(d => d.FacturaNavigation).WithMany()
                .HasForeignKey(d => d.Factura)
                .HasConstraintName("FK_OrdenadorFactura_Factura");

            entity.HasOne(d => d.OrdenadorNavigation).WithMany()
                .HasForeignKey(d => d.Ordenador)
                .HasConstraintName("FK_OrdenadorFactura_Ordenador");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

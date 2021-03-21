﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_8.Models
{
    public partial class vacunadosrdv2Context : DbContext
    {
        public vacunadosrdv2Context()
        {
        }

        public vacunadosrdv2Context(DbContextOptions<vacunadosrdv2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Signozodiacal> Signozodiacal { get; set; }
        public virtual DbSet<Vacunas> Vacunas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;uid=root;database=vacunadosrdv2", x => x.ServerVersion("10.4.16-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.ToTable("pacientes");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("ProvinciaId");

                entity.HasIndex(e => e.SignoId)
                    .HasName("SignoId");

                entity.HasIndex(e => e.VacunaId)
                    .HasName("VacunaId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaPrimeraVacuna).HasColumnType("datetime");

                entity.Property(e => e.FechaSegundaVacuna).HasColumnType("datetime");

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasColumnType("float(100,30)");

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasColumnType("float(100,30)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProvinciaId).HasColumnType("int(11)");

                entity.Property(e => e.SignoId).HasColumnType("int(11)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.VacunaId).HasColumnType("int(11)");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pacientes_ibfk_2");

                entity.HasOne(d => d.Signo)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.SignoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pacientes_ibfk_3");

                entity.HasOne(d => d.Vacuna)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.VacunaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pacientes_ibfk_1");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.ToTable("provincias");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Signozodiacal>(entity =>
            {
                entity.ToTable("signozodiacal");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Signo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Vacunas>(entity =>
            {
                entity.ToTable("vacunas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

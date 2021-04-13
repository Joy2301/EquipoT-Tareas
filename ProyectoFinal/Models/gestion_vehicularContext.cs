using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoFinal.Models
{
    public partial class gestion_vehicularContext : DbContext
    {
        public gestion_vehicularContext()
        {
        }

        public gestion_vehicularContext(DbContextOptions<gestion_vehicularContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Reservaciones> Reservaciones { get; set; }
        public virtual DbSet<RolUsuarios> RolUsuarios { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public virtual DbSet<Tiposangre> Tiposangre { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;uid=root;database=gestion_vehicular", x => x.ServerVersion("10.4.16-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.ToTable("clientes");

                entity.HasIndex(e => e.TipoSangreId)
                    .HasName("TipoSangreId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClienteActivo)
                    .IsRequired()
                    .HasColumnName("Cliente_Activo")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FotoCliente)
                    .HasColumnName("Foto_Cliente")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FotoLicencia)
                    .HasColumnName("Foto_Licencia")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Licencia)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nacionalidad)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoSangreId).HasColumnType("int(11)");

                entity.HasOne(d => d.TipoSangre)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.TipoSangreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_ibfk_1");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.ToTable("municipios");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("ProvinciaId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Latitud).HasColumnType("float(100,30)");

                entity.Property(e => e.Longitud).HasColumnType("float(100,30)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProvinciaId).HasColumnType("int(11)");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("municipios_ibfk_1");
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

            modelBuilder.Entity<Reservaciones>(entity =>
            {
                entity.ToTable("reservaciones");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("ClienteId");

                entity.HasIndex(e => e.VehiculoId)
                    .HasName("VehiculoId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClienteId).HasColumnType("int(11)");

                entity.Property(e => e.Debe).HasColumnType("decimal(13,2)");

                entity.Property(e => e.FacturaPagada)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.HaPagado)
                    .HasColumnName("Ha_Pagado")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoTotal).HasColumnType("decimal(13,2)");

                entity.Property(e => e.VehiculoDevuelto)
                    .IsRequired()
                    .HasColumnName("Vehiculo_Devuelto")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehiculoId).HasColumnType("int(11)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reservaciones_ibfk_2");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.Reservaciones)
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reservaciones_ibfk_1");
            });

            modelBuilder.Entity<RolUsuarios>(entity =>
            {
                entity.ToTable("rol_usuarios");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.ToTable("tipo_vehiculo");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Tiposangre>(entity =>
            {
                entity.ToTable("tiposangre");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.RolId)
                    .HasName("RolId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RolId).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioActivo)
                    .HasColumnName("Usuario_Activo")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_ibfk_1");
            });

            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.ToTable("vehiculos");

                entity.HasIndex(e => e.TipoId)
                    .HasName("TipoId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Año).HasColumnType("year(4)");

                entity.Property(e => e.CapacidadDeCarga)
                    .HasColumnName("Capacidad_de_Carga")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Foto)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Latitud).HasColumnType("float(100,30)");

                entity.Property(e => e.Longitud).HasColumnType("float(100,30)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NroSeguro)
                    .IsRequired()
                    .HasColumnName("Nro_Seguro")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pasajeros).HasColumnType("int(11)");

                entity.Property(e => e.Precio).HasColumnType("decimal(13,2)");

                entity.Property(e => e.TipoId).HasColumnType("int(11)");

                entity.Property(e => e.VehiculoDisponible)
                    .IsRequired()
                    .HasColumnName("Vehiculo_Disponible")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehiculos_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

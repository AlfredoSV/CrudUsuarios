using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CrudUsuarios.Models
{
    public partial class sql_ServerContext : DbContext
    {
        public sql_ServerContext()
        {
        }

        public sql_ServerContext(DbContextOptions<sql_ServerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AcercaDeMi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("acercaDeMi");

                entity.Property(e => e.ApellidoM)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellidoM");

                entity.Property(e => e.ApellidoP)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellidoP");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaNacimeinto)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimeinto");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

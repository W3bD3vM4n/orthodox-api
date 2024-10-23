using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Orthodox.Data.Models
{
    public partial class OrthodoxDbContext : DbContext
    {
        public OrthodoxDbContext()
        {
        }

        public OrthodoxDbContext(DbContextOptions<OrthodoxDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evento> Eventos { get; set; } = null!;
        public virtual DbSet<Cartelera> Carteleras { get; set; } = null!;
        public virtual DbSet<PensamientoDia> PensamientosDia { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>().ToTable("Evento", "dbo");
            modelBuilder.Entity<Cartelera>().ToTable("Cartelera", "dbo");
            modelBuilder.Entity<PensamientoDia>().ToTable("PensamientoDia", "dbo");
            modelBuilder.Entity<Usuario>().ToTable("Usuario", "dbo");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Usuarios>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tarea>().ToTable("Tarea");
            modelBuilder.Entity<Tarea>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Detalle>().ToTable("Detalle");
            modelBuilder.Entity<Detalle>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Recurso>().ToTable("Recurso");
            modelBuilder.Entity<Recurso>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<TipoTarea>().ToTable("TipoTarea");
            modelBuilder.Entity<TipoTarea>().Property(p => p.Id).ValueGeneratedOnAdd();

        }

        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Recurso> Recurso { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TipoTarea> TipoTarea { get; set; }

    }
}

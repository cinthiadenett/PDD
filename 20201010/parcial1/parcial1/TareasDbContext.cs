using Microsoft.EntityFrameworkCore;
using parcial1;
using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
    public class TareasDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=tareas.db");

        }

       
    
            protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuario>().Property(p => p.Nombre).HasMaxLength(30);
            modelBuilder.Entity<Usuario>().Property(p => p.Clave).IsRequired();

            modelBuilder.Entity<Tarea>().ToTable("Tarea");
            modelBuilder.Entity<Tarea>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tarea>().Property(p => p.Titular).HasMaxLength(20);
            modelBuilder.Entity<Tarea>().Property(p => p.Vencimiento).IsRequired();

            modelBuilder.Entity<Detalles>().ToTable("Detalle");
            modelBuilder.Entity<Detalles>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Detalles>().Property(p => p.Fecha).IsRequired();
            modelBuilder.Entity<Detalles>().Property(p => p.Tiempo).IsRequired();

            modelBuilder.Entity<Recursos>().ToTable("Recurso");
            modelBuilder.Entity<Recursos>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Recursos>().Property(p => p.Nombre).HasMaxLength(20);

        }
    }

    public DbSet<Detalles> Detalle { get; set; }
    public DbSet<Tarea> Tarea { get; set; }
    public DbSet<Recursos> Recursos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    

} 

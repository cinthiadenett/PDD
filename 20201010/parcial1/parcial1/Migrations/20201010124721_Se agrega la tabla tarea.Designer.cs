﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using parcial1;

namespace parcial1.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201010124721_Se agrega la tabla tarea")]
    partial class Seagregalatablatarea
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("parcial1.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Titular")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("parcial1.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("char(20)");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
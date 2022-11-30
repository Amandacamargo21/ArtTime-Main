﻿// <auto-generated />
using System;
using ArtTime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtTime.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ArtTime.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int?>("artistaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("clienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataAgendamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("localDaTattoo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("artistaId");

                    b.HasIndex("clienteId");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("ArtTime.Models.Artista", b =>
                {
<<<<<<< HEAD
                    b.Property<int>("Id")
=======
                    b.Property<int>("artistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("dataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("artistaId");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("ArtTime.Models.Cliente", b =>
                {
                    b.Property<int>("clienteId")
>>>>>>> a8553f0df7c4c15ea7488f37427dde611ceefe2f
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("dataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");
<<<<<<< HEAD
=======

                    b.HasKey("clienteId");
>>>>>>> a8553f0df7c4c15ea7488f37427dde611ceefe2f

                    b.HasKey("Id");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("ArtTime.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("dataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ArtTime.Models.Agendamento", b =>
                {
                    b.HasOne("ArtTime.Models.Artista", "Artista")
                        .WithMany()
                        .HasForeignKey("artistaId");

                    b.HasOne("ArtTime.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("clienteId");

                    b.Navigation("Artista");

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}

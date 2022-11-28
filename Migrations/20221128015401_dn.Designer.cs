﻿// <auto-generated />
using System;
using ArtTime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtTime.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221128015401_dn")]
    partial class dn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("artistaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("clienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataAgendamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("localDaTattoo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("artistaId");

                    b.HasIndex("clienteId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("ArtTime.Models.Artista", b =>
                {
                    b.Property<int>("artistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("dataNascimento")
                        .HasColumnType("TEXT");

                    b.HasKey("artistaId");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("ArtTime.Models.Cliente", b =>
                {
                    b.Property<int>("clienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("dataNascimento")
                        .HasColumnType("TEXT");

                    b.HasKey("clienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ArtTime.Models.Agendamento", b =>
                {
                    b.HasOne("ArtTime.Models.Artista", "Artista")
                        .WithMany()
                        .HasForeignKey("artistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtTime.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}

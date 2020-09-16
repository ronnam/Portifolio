﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NCamadas.App.Dados.Context;

namespace NCamadas.App.Dados.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    [Migration("20200908194324_Cliente")]
    partial class Cliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Cliente", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(11);

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("DATE");

                    b.HasKey("UsuarioId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasColumnType("varchar")
                        .HasMaxLength(25);

                    b.Property<string>("NomeDoMeio")
                        .HasColumnType("varchar")
                        .HasMaxLength(25);

                    b.Property<string>("UltimoNome")
                        .HasColumnType("varchar")
                        .HasMaxLength(35);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Cliente", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Pessoa.Usuario", "Usuario")
                        .WithOne("ClienteRegistrado")
                        .HasForeignKey("NCamadas.App.Negocio.Pessoa.Cliente", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

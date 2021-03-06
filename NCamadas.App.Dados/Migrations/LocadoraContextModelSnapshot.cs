﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NCamadas.App.Dados.Context;

namespace NCamadas.App.Dados.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    partial class LocadoraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Ano")
                        .HasColumnType("DATE");

                    b.Property<int>("Classificacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Genero")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("DECIMAL(5,2)");

                    b.Property<string>("Titulo")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.FilmeLocacao", b =>
                {
                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("LocacaoId")
                        .HasColumnType("int");

                    b.HasKey("FilmeId", "LocacaoId");

                    b.HasIndex("LocacaoId");

                    b.ToTable("FilmeLocacoes");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Tempo")
                        .HasColumnType("DATE");

                    b.Property<decimal>("Total")
                        .HasColumnType("DECIMAL");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.UsuarioFilme", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "FilmeId");

                    b.HasIndex("FilmeId");

                    b.ToTable("UsuarioFilmes");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(11);

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("DATE");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Endereco", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(50);

                    b.Property<string>("Cidade")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(20);

                    b.Property<string>("Complemento")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(20);

                    b.Property<string>("Estado")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(2);

                    b.Property<string>("Logradouro")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(100);

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClienteId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Pagamento", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDePagamento")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Telefone", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(11);

                    b.Property<string>("Residencial")
                        .HasColumnType("VARCHAR")
                        .HasMaxLength(10);

                    b.HasKey("ClienteId");

                    b.ToTable("Telefones");
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

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.FilmeLocacao", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Locadora.Filme", "Filme")
                        .WithMany("Locacoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NCamadas.App.Negocio.Locadora.Locacao", "Locacao")
                        .WithMany("Filmes")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.Locacao", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Pessoa.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Locadora.UsuarioFilme", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Locadora.Filme", "Filme")
                        .WithMany("UsuarioFilme")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NCamadas.App.Negocio.Pessoa.Usuario", "Usuario")
                        .WithMany("Filmes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Cliente", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Pessoa.Usuario", "Usuario")
                        .WithOne("Cliente")
                        .HasForeignKey("NCamadas.App.Negocio.Pessoa.Cliente", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Endereco", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Pessoa.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("NCamadas.App.Negocio.Pessoa.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Pagamento", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Pessoa.Cliente", "Cliente")
                        .WithOne("Pagamento")
                        .HasForeignKey("NCamadas.App.Negocio.Pessoa.Pagamento", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NCamadas.App.Negocio.Pessoa.Telefone", b =>
                {
                    b.HasOne("NCamadas.App.Negocio.Pessoa.Cliente", "Cliente")
                        .WithOne("Telefone")
                        .HasForeignKey("NCamadas.App.Negocio.Pessoa.Telefone", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

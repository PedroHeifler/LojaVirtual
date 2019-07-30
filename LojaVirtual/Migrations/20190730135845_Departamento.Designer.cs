﻿// <auto-generated />
using System;
using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LojaVirtual.Migrations
{
    [DbContext(typeof(LojaVirtualContext))]
    [Migration("20190730135845_Departamento")]
    partial class Departamento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaVirtual.Models.Departamento", b =>
                {
                    b.Property<int>("IdDepartamento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genero")
                        .IsRequired();

                    b.Property<string>("TpPeca")
                        .IsRequired();

                    b.HasKey("IdDepartamento");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("LojaVirtual.Models.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("CEP")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("Complemento")
                        .IsRequired();

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<int>("Numero");

                    b.Property<string>("Rua")
                        .IsRequired();

                    b.Property<int?>("UsuarioIdUsuario");

                    b.HasKey("IdEndereco");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("LojaVirtual.Models.Login", b =>
                {
                    b.Property<int>("IdLogin")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("TpUsuario");

                    b.HasKey("IdLogin");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartamentoIdDepartamento");

                    b.Property<string>("Imagem");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("SKU");

                    b.HasKey("IdProduto");

                    b.HasIndex("DepartamentoIdDepartamento");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("LojaVirtual.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int?>("LoginIdLogin");

                    b.Property<string>("NomeCompleto")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("IdUsuario");

                    b.HasIndex("LoginIdLogin");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LojaVirtual.Models.Endereco", b =>
                {
                    b.HasOne("LojaVirtual.Models.Usuario")
                        .WithMany("Endereco")
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("LojaVirtual.Models.Produto", b =>
                {
                    b.HasOne("LojaVirtual.Models.Departamento", "Departamento")
                        .WithMany("Produtos")
                        .HasForeignKey("DepartamentoIdDepartamento");
                });

            modelBuilder.Entity("LojaVirtual.Models.Usuario", b =>
                {
                    b.HasOne("LojaVirtual.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginIdLogin");
                });
#pragma warning restore 612, 618
        }
    }
}

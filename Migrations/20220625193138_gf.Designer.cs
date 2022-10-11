﻿// <auto-generated />
using ApiTechIlha.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiTechIlha.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220625193138_gf")]
    partial class gf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiTechIlha.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("CPF")
                        .HasColumnType("integer");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Telefone")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ApiTechIlha.Models.Funcionario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("fone")
                        .HasColumnType("integer");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("wage")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("ApiTechIlha.Models.Movimentacoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("movimentacoes");
                });

            modelBuilder.Entity("ApiTechIlha.Models.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("integer");

                    b.Property<int>("Imei")
                        .HasColumnType("integer");

                    b.Property<int>("Preco")
                        .HasColumnType("integer");

                    b.Property<int>("TipoServicoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("TipoServicoId");

                    b.ToTable("OrdemServico");
                });

            modelBuilder.Entity("ApiTechIlha.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("ApiTechIlha.Models.TipoServico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("servicoNome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("TipoServico");
                });

            modelBuilder.Entity("ApiTechIlha.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Email = "julio.admin@bol.br",
                            Name = "Julio",
                            Password = "admin123",
                            Role = "Administrator",
                            Surname = "Lossavaro",
                            Username = "julio_admin"
                        },
                        new
                        {
                            id = 2,
                            Email = "julio.user@bol.br",
                            Name = "Julio",
                            Password = "user123",
                            Role = "Standard",
                            Surname = "Lossavaro",
                            Username = "julio_user"
                        });
                });

            modelBuilder.Entity("ApiTechIlha.Models.Venda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("idProduto")
                        .HasColumnType("integer");

                    b.Property<string>("nomeProduto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("quantidade")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("ApiTechIlha.Models.OrdemServico", b =>
                {
                    b.HasOne("ApiTechIlha.Models.Cliente", "Cliente")
                        .WithMany("OSs")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTechIlha.Models.Funcionario", "Funcionario")
                        .WithMany("OSs")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTechIlha.Models.TipoServico", "TipoServico")
                        .WithMany("OSs")
                        .HasForeignKey("TipoServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");

                    b.Navigation("TipoServico");
                });

            modelBuilder.Entity("ApiTechIlha.Models.Cliente", b =>
                {
                    b.Navigation("OSs");
                });

            modelBuilder.Entity("ApiTechIlha.Models.Funcionario", b =>
                {
                    b.Navigation("OSs");
                });

            modelBuilder.Entity("ApiTechIlha.Models.TipoServico", b =>
                {
                    b.Navigation("OSs");
                });
#pragma warning restore 612, 618
        }
    }
}

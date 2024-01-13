﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoCRUDSMC.Data;

#nullable disable

namespace ProjetoCRUDSMC.Migrations.RelatorioFuncionario
{
    [DbContext(typeof(RelatorioFuncionarioContext))]
    [Migration("20240112230627_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoCRUDSMC.Models.RelatorioFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataRelatorio")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataRelatorio");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("FuncionarioId");

                    b.Property<string>("Relatorio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Relatorio");

                    b.HasKey("Id");

                    b.ToTable("RelatorioFuncionarios");
                });
#pragma warning restore 612, 618
        }
    }
}

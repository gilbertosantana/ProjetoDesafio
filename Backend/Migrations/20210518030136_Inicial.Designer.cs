﻿// <auto-generated />
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(FrotaContext))]
    [Migration("20210518030136_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCarro")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoFabricacao")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("AnoFabricacao");

                    b.Property<string>("Cor")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Cor");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Modelo");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Nome");

                    b.Property<string>("Placa")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Placa");

                    b.HasKey("Id");

                    b.HasIndex("Placa")
                        .IsUnique()
                        .HasFilter("[Placa] IS NOT NULL");

                    b.ToTable("Carro");
                });
#pragma warning restore 612, 618
        }
    }
}

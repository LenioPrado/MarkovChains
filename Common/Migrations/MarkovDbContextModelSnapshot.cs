﻿// <auto-generated />
using System;
using Common.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Common.Migrations
{
    [DbContext(typeof(MarkovDbContext))]
    partial class MarkovDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Model.Estados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Duracao")
                        .HasColumnType("float");

                    b.Property<string>("EstadoDestino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoOrigem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ocorrencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UG")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("estados", "markov");
                });
#pragma warning restore 612, 618
        }
    }
}

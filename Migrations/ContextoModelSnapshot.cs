﻿// <auto-generated />
using F_NF_Negocio.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F_NF_Negocio.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("F_NF_Negocio.Models.Preguntas_Respuestas", b =>
                {
                    b.Property<int>("PreguntaR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Explicacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Preguntas")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Respuestas")
                        .HasColumnType("INTEGER");

                    b.HasKey("PreguntaR_ID");

                    b.ToTable("Preguntas_Respuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
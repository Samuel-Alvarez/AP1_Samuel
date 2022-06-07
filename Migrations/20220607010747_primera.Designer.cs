﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Parcial1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220607010747_primera")]
    partial class primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("Aportes", b =>
                {
                    b.Property<int>("AporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("Persona")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.HasKey("AporteId");

                    b.ToTable("aportes");
                });
#pragma warning restore 612, 618
        }
    }
}

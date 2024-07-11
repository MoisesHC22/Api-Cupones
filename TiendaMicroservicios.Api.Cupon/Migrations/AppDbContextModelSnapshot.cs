﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaMicroservicios.Api.Cupon.Data;

#nullable disable

namespace TiendaMicroservicios.Api.Cupon.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TiendaMicroservicios.Api.Cupon.Models.Cupon", b =>
                {
                    b.Property<int>("CuponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuponId"));

                    b.Property<string>("CuponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DescuentoMinimo")
                        .HasColumnType("int");

                    b.Property<double>("PorcetanjeDescuento")
                        .HasColumnType("float");

                    b.HasKey("CuponId");

                    b.ToTable("Cupons");
                });
#pragma warning restore 612, 618
        }
    }
}

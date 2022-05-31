﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcDenemeHello.Controllers;

namespace MvcDenemeHello.Migrations
{
    [DbContext(typeof(OkulContext))]
    [Migration("20220531162807_dbogr")]
    partial class dbogr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcDenemeHello.Models.Ogrenci", b =>
                {
                    b.Property<string>("Ad")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Yas")
                        .HasColumnType("tinyint");

                    b.HasKey("Ad");

                    b.ToTable("tblOgr");
                });
#pragma warning restore 612, 618
        }
    }
}
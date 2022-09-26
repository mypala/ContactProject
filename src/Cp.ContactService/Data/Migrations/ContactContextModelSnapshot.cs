﻿// <auto-generated />
using Cp.ContactService.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cp.ContactService.Data.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("cp")
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cp.ContactService.Protos.ContactModel", b =>
                {
                    b.Property<long>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("uuid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UUID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("ad");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("firma");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("soyad");

                    b.HasKey("UUID")
                        .HasName("pk_contacts");

                    b.ToTable("contacts", "cp");

                    b.HasData(
                        new
                        {
                            UUID = 1L,
                            Ad = "Ayşe",
                            Firma = "Company One",
                            Soyad = "Çiçek"
                        },
                        new
                        {
                            UUID = 2L,
                            Ad = "Ali",
                            Firma = "Company One",
                            Soyad = "Böcek"
                        },
                        new
                        {
                            UUID = 3L,
                            Ad = "Murat",
                            Firma = "Company Two",
                            Soyad = "Ağaç"
                        },
                        new
                        {
                            UUID = 4L,
                            Ad = "Bahar",
                            Firma = "Company Two",
                            Soyad = "Yeni"
                        },
                        new
                        {
                            UUID = 5L,
                            Ad = "Fatma",
                            Firma = "Company Three",
                            Soyad = "Öz"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

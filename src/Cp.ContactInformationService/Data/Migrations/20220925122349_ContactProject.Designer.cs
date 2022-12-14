// <auto-generated />
using Cp.ContactInformationService.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cp.ContactInformationService.Data.Migrations
{
    [DbContext(typeof(ContactInformationContext))]
    [Migration("20220925122349_ContactProject")]
    partial class ContactProject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("cp")
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cp.ContactInformationService.Protos.ContactInformation", b =>
                {
                    b.Property<long>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("uuid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UUID"));

                    b.Property<long>("ContactId")
                        .HasColumnType("bigint")
                        .HasColumnName("contactid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("content");

                    b.Property<int>("InformationType")
                        .HasColumnType("integer")
                        .HasColumnName("informationtype");

                    b.HasKey("UUID")
                        .HasName("pk_contactinformations");

                    b.ToTable("contactinformations", "cp");

                    b.HasData(
                        new
                        {
                            UUID = 1L,
                            ContactId = 1L,
                            Content = "05320000000",
                            InformationType = 0
                        },
                        new
                        {
                            UUID = 2L,
                            ContactId = 1L,
                            Content = "mypala@mail.com",
                            InformationType = 1
                        },
                        new
                        {
                            UUID = 3L,
                            ContactId = 1L,
                            Content = "Ümraniye",
                            InformationType = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

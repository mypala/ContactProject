using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cp.ContactService.Data.Migrations
{
    public partial class ContactProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cp");

            migrationBuilder.CreateTable(
                name: "contacts",
                schema: "cp",
                columns: table => new
                {
                    uuid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ad = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    soyad = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    firma = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contacts", x => x.uuid);
                });

            migrationBuilder.InsertData(
                schema: "cp",
                table: "contacts",
                columns: new[] { "uuid", "ad", "firma", "soyad" },
                values: new object[,]
                {
                    { 1L, "Ayşe", "Company One", "Çiçek" },
                    { 2L, "Ali", "Company One", "Böcek" },
                    { 3L, "Murat", "Company Two", "Ağaç" },
                    { 4L, "Bahar", "Company Two", "Yeni" },
                    { 5L, "Fatma", "Company Three", "Öz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts",
                schema: "cp");
        }
    }
}

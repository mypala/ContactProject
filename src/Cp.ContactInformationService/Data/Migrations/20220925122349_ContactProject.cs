using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cp.ContactInformationService.Data.Migrations
{
    public partial class ContactProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cp");

            migrationBuilder.CreateTable(
                name: "contactinformations",
                schema: "cp",
                columns: table => new
                {
                    uuid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    contactid = table.Column<long>(type: "bigint", nullable: false),
                    informationtype = table.Column<int>(type: "integer", nullable: false),
                    content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contactinformations", x => x.uuid);
                });

            migrationBuilder.InsertData(
                schema: "cp",
                table: "contactinformations",
                columns: new[] { "uuid", "contactid", "content", "informationtype" },
                values: new object[,]
                {
                    { 1L, 1L, "05320000000", 0 },
                    { 2L, 1L, "mypala@mail.com", 1 },
                    { 3L, 1L, "Ümraniye", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactinformations",
                schema: "cp");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcDenemeHello.Migrations
{
    public partial class dbogr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOgr",
                columns: table => new
                {
                    Ad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(nullable: false),
                    Yas = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgr", x => x.Ad);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgr");
        }
    }
}

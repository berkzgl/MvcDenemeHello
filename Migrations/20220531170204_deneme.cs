using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcDenemeHello.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgr",
                table: "tblOgr");

            migrationBuilder.AlterColumn<int>(
                name: "Yas",
                table: "tblOgr",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "tblOgr",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgr",
                table: "tblOgr",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblOgr",
                table: "tblOgr");

            migrationBuilder.DropColumn(
                name: "id",
                table: "tblOgr");

            migrationBuilder.AlterColumn<byte>(
                name: "Yas",
                table: "tblOgr",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblOgr",
                table: "tblOgr",
                column: "Ad");
        }
    }
}

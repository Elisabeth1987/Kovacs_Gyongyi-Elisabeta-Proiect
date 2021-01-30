using Microsoft.EntityFrameworkCore.Migrations;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Migrations
{
    public partial class Cicluri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CicluID",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ciclu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Ciclu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclu", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_CicluID",
                table: "Student",
                column: "CicluID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Ciclu_CicluID",
                table: "Student",
                column: "CicluID",
                principalTable: "Ciclu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Ciclu_CicluID",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Ciclu");

            migrationBuilder.DropIndex(
                name: "IX_Student_CicluID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CicluID",
                table: "Student");
        }
    }
}

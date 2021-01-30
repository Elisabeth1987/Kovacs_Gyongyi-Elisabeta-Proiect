using Microsoft.EntityFrameworkCore.Migrations;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Migrations
{
    public partial class Specializare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specializare",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "SpecializareID",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specializare",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Specializare = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializare", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_SpecializareID",
                table: "Student",
                column: "SpecializareID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Specializare_SpecializareID",
                table: "Student",
                column: "SpecializareID",
                principalTable: "Specializare",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Specializare_SpecializareID",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Specializare");

            migrationBuilder.DropIndex(
                name: "IX_Student_SpecializareID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SpecializareID",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "Specializare",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

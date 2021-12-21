using Microsoft.EntityFrameworkCore.Migrations;

namespace Ekz_Apteka.Migrations
{
    public partial class UpdateMedicine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Medicines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines",
                column: "MedicineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines");

            migrationBuilder.RenameTable(
                name: "Medicines",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "MedicineId");
        }
    }
}

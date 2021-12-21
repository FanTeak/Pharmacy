using Microsoft.EntityFrameworkCore.Migrations;

namespace Ekz_Apteka.Migrations
{
    public partial class Addedtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicineTypeId",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MedicineTypes",
                columns: table => new
                {
                    MedicineTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineTypeName = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineTypes", x => x.MedicineTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_MedicineTypeId",
                table: "Medicines",
                column: "MedicineTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_MedicineTypes_MedicineTypeId",
                table: "Medicines",
                column: "MedicineTypeId",
                principalTable: "MedicineTypes",
                principalColumn: "MedicineTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_MedicineTypes_MedicineTypeId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "MedicineTypes");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_MedicineTypeId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "MedicineTypeId",
                table: "Medicines");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_130 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategoriesId",
                table: "InformationAboutEducations");

            migrationBuilder.RenameColumn(
                name: "AssignedCategoriesId",
                table: "InformationAboutEducations",
                newName: "AssignedCategory");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_AssignedCategoriesId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_AssignedCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations",
                column: "AssignedCategory",
                principalTable: "AssignedCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations");

            migrationBuilder.RenameColumn(
                name: "AssignedCategory",
                table: "InformationAboutEducations",
                newName: "AssignedCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_AssignedCategory",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_AssignedCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategoriesId",
                table: "InformationAboutEducations",
                column: "AssignedCategoriesId",
                principalTable: "AssignedCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

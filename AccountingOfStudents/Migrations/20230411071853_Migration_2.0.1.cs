using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_201 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducation");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocument_KindOfDocumentId",
                table: "InformationAboutEducation",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocument",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocument_KindOfDocumentId",
                table: "InformationAboutEducation");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducation",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocument",
                principalColumn: "Id");
        }
    }
}

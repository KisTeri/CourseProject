using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_203 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id",
                table: "InformationAboutEducations");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducations",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id",
                table: "InformationAboutEducations",
                column: "PersonalInformationOfStudentId",
                principalTable: "PersonalInformationOfStudents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id",
                table: "InformationAboutEducations");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducations",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id",
                table: "InformationAboutEducations",
                column: "PersonalInformationOfStudentId",
                principalTable: "PersonalInformationOfStudents",
                principalColumn: "Id");
        }
    }
}

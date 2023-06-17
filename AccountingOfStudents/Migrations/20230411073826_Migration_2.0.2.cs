using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_202 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocument_KindOfDocumentId",
                table: "InformationAboutEducation");

            migrationBuilder.RenameTable(
                name: "SendingOrganization",
                newName: "SendingOrganizations");

            migrationBuilder.RenameTable(
                name: "PersonalInformationOfStudent",
                newName: "PersonalInformationOfStudents");

            migrationBuilder.RenameTable(
                name: "KindOfDocument",
                newName: "KindOfDocuments");

            migrationBuilder.RenameTable(
                name: "InformationAboutEducation",
                newName: "InformationAboutEducations");

            migrationBuilder.RenameTable(
                name: "EducationalProgram",
                newName: "EducationalPrograms");

            migrationBuilder.RenameTable(
                name: "AssignedCategory",
                newName: "AssignedCategories");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducation_SendingOrganizationId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_SendingOrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducation_PersonalInformationOfStudentId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_PersonalInformationOfStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducation_KindOfDocumentId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_KindOfDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducation_EducationalProgramId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_EducationalProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducation_AssignedCategoryId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_AssignedCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducations",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocuments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducations");

            migrationBuilder.RenameTable(
                name: "SendingOrganizations",
                newName: "SendingOrganization");

            migrationBuilder.RenameTable(
                name: "PersonalInformationOfStudents",
                newName: "PersonalInformationOfStudent");

            migrationBuilder.RenameTable(
                name: "KindOfDocuments",
                newName: "KindOfDocument");

            migrationBuilder.RenameTable(
                name: "InformationAboutEducations",
                newName: "InformationAboutEducation");

            migrationBuilder.RenameTable(
                name: "EducationalPrograms",
                newName: "EducationalProgram");

            migrationBuilder.RenameTable(
                name: "AssignedCategories",
                newName: "AssignedCategory");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_SendingOrganizationId",
                table: "InformationAboutEducation",
                newName: "IX_InformationAboutEducation_SendingOrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentId",
                table: "InformationAboutEducation",
                newName: "IX_InformationAboutEducation_PersonalInformationOfStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_KindOfDocumentId",
                table: "InformationAboutEducation",
                newName: "IX_InformationAboutEducation_KindOfDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_EducationalProgramId",
                table: "InformationAboutEducation",
                newName: "IX_InformationAboutEducation_EducationalProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_AssignedCategoryId",
                table: "InformationAboutEducation",
                newName: "IX_InformationAboutEducation_AssignedCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocument_KindOfDocumentId",
                table: "InformationAboutEducation",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocument",
                principalColumn: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_200 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_EducationalPrograms_EducationalProgramsId",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_KindOfDocuments_KindOfDocumentsId",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_PersonalInformationOfStudents_PersonalInformationOfStudentsId",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendingOrganizations",
                table: "SendingOrganizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInformationOfStudents",
                table: "PersonalInformationOfStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KindOfDocuments",
                table: "KindOfDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InformationAboutEducations",
                table: "InformationAboutEducations");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_AssignedCategory",
                table: "InformationAboutEducations");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_EducationalProgramsId",
                table: "InformationAboutEducations");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_KindOfDocumentsId",
                table: "InformationAboutEducations");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_SendingOrganization",
                table: "InformationAboutEducations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalPrograms",
                table: "EducationalPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignedCategories",
                table: "AssignedCategories");

            migrationBuilder.DropColumn(
                name: "AssignedCategory",
                table: "InformationAboutEducations");

            migrationBuilder.DropColumn(
                name: "SendingOrganization",
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

            migrationBuilder.RenameColumn(
                name: "PersonalInformationOfStudentsId",
                table: "InformationAboutEducation",
                newName: "SendingOrganizationId");

            migrationBuilder.RenameColumn(
                name: "KindOfDocumentsId",
                table: "InformationAboutEducation",
                newName: "PersonalInformationOfStudentId");

            migrationBuilder.RenameColumn(
                name: "EducationalProgramsId",
                table: "InformationAboutEducation",
                newName: "KindOfDocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentsId",
                table: "InformationAboutEducation",
                newName: "IX_InformationAboutEducation_SendingOrganizationId");

            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "SendingOrganization",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SendingOrganization",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Snils",
                table: "PersonalInformationOfStudent",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "PersonalInformationOfStudent",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PersonalInformationOfStudent",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PersonalInformationOfStudent",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "InformationAboutEducationId",
                table: "PersonalInformationOfStudent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PersonalInformationOfStudent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InformationAboutEducationId",
                table: "KindOfDocument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "KindOfDocument",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AssignedCategoryId",
                table: "InformationAboutEducation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EducationalProgramId",
                table: "InformationAboutEducation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InformationAboutEducation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "NameOfProgram",
                table: "EducationalProgram",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KindOfProgram",
                table: "EducationalProgram",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EducationalProgram",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "AssignedCategory",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AssignedCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendingOrganizations_Id",
                table: "SendingOrganization",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInformationOfStudents_Id",
                table: "PersonalInformationOfStudent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KindOfDocuments_Id",
                table: "KindOfDocument",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InformationAboutEducations_Id",
                table: "InformationAboutEducation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalPrograms_Id",
                table: "EducationalProgram",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignedCategories_Id",
                table: "AssignedCategory",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducation_AssignedCategoryId",
                table: "InformationAboutEducation",
                column: "AssignedCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducation_EducationalProgramId",
                table: "InformationAboutEducation",
                column: "EducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducation_KindOfDocumentId",
                table: "InformationAboutEducation",
                column: "KindOfDocumentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducation_PersonalInformationOfStudentId",
                table: "InformationAboutEducation",
                column: "PersonalInformationOfStudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducation",
                column: "KindOfDocumentId",
                principalTable: "KindOfDocument",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducation_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id",
                table: "InformationAboutEducation",
                column: "PersonalInformationOfStudentId",
                principalTable: "PersonalInformationOfStudent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategoryId_AssignedCategories_Id",
                table: "InformationAboutEducation",
                column: "AssignedCategoryId",
                principalTable: "AssignedCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_EducationalProgramId_EducationalProgram_Id",
                table: "InformationAboutEducation",
                column: "EducationalProgramId",
                principalTable: "EducationalProgram",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizationId_SendingOrganizations_Id",
                table: "InformationAboutEducation",
                column: "SendingOrganizationId",
                principalTable: "SendingOrganization",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_KindOfDocumentId_KindOfDocument_Id",
                table: "InformationAboutEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducation_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id",
                table: "InformationAboutEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategoryId_AssignedCategories_Id",
                table: "InformationAboutEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_EducationalProgramId_EducationalProgram_Id",
                table: "InformationAboutEducation");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizationId_SendingOrganizations_Id",
                table: "InformationAboutEducation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendingOrganizations_Id",
                table: "SendingOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInformationOfStudents_Id",
                table: "PersonalInformationOfStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KindOfDocuments_Id",
                table: "KindOfDocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InformationAboutEducations_Id",
                table: "InformationAboutEducation");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducation_AssignedCategoryId",
                table: "InformationAboutEducation");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducation_EducationalProgramId",
                table: "InformationAboutEducation");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducation_KindOfDocumentId",
                table: "InformationAboutEducation");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducation_PersonalInformationOfStudentId",
                table: "InformationAboutEducation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalPrograms_Id",
                table: "EducationalProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignedCategories_Id",
                table: "AssignedCategory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SendingOrganization");

            migrationBuilder.DropColumn(
                name: "InformationAboutEducationId",
                table: "PersonalInformationOfStudent");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PersonalInformationOfStudent");

            migrationBuilder.DropColumn(
                name: "InformationAboutEducationId",
                table: "KindOfDocument");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "KindOfDocument");

            migrationBuilder.DropColumn(
                name: "AssignedCategoryId",
                table: "InformationAboutEducation");

            migrationBuilder.DropColumn(
                name: "EducationalProgramId",
                table: "InformationAboutEducation");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InformationAboutEducation");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EducationalProgram");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AssignedCategory");

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

            migrationBuilder.RenameColumn(
                name: "SendingOrganizationId",
                table: "InformationAboutEducations",
                newName: "PersonalInformationOfStudentsId");

            migrationBuilder.RenameColumn(
                name: "PersonalInformationOfStudentId",
                table: "InformationAboutEducations",
                newName: "KindOfDocumentsId");

            migrationBuilder.RenameColumn(
                name: "KindOfDocumentId",
                table: "InformationAboutEducations",
                newName: "EducationalProgramsId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducation_SendingOrganizationId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_PersonalInformationOfStudentsId");

            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "SendingOrganizations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Snils",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "AssignedCategory",
                table: "InformationAboutEducations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SendingOrganization",
                table: "InformationAboutEducations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameOfProgram",
                table: "EducationalPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "KindOfProgram",
                table: "EducationalPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "AssignedCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendingOrganizations",
                table: "SendingOrganizations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInformationOfStudents",
                table: "PersonalInformationOfStudents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KindOfDocuments",
                table: "KindOfDocuments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InformationAboutEducations",
                table: "InformationAboutEducations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalPrograms",
                table: "EducationalPrograms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignedCategories",
                table: "AssignedCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_AssignedCategory",
                table: "InformationAboutEducations",
                column: "AssignedCategory");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_EducationalProgramsId",
                table: "InformationAboutEducations",
                column: "EducationalProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_KindOfDocumentsId",
                table: "InformationAboutEducations",
                column: "KindOfDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_SendingOrganization",
                table: "InformationAboutEducations",
                column: "SendingOrganization");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations",
                column: "AssignedCategory",
                principalTable: "AssignedCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_EducationalPrograms_EducationalProgramsId",
                table: "InformationAboutEducations",
                column: "EducationalProgramsId",
                principalTable: "EducationalPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_KindOfDocuments_KindOfDocumentsId",
                table: "InformationAboutEducations",
                column: "KindOfDocumentsId",
                principalTable: "KindOfDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_PersonalInformationOfStudents_PersonalInformationOfStudentsId",
                table: "InformationAboutEducations",
                column: "PersonalInformationOfStudentsId",
                principalTable: "PersonalInformationOfStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations",
                column: "SendingOrganization",
                principalTable: "SendingOrganizations",
                principalColumn: "Id");
        }
    }
}

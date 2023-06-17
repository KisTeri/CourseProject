using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_110 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AssignedCategories",
                table: "InformationAboutEducations",
                newName: "AssignedCategoriesId");

            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "SendingOrganizations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Snils",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "PersonalInformationOfStudents",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "PersonalInformationOfStudents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Series",
                table: "KindOfDocuments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "KindOfDocuments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfIssue",
                table: "KindOfDocuments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartOfEducation",
                table: "InformationAboutEducations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ProtocolNumber",
                table: "InformationAboutEducations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndOfEducation",
                table: "InformationAboutEducations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ContractNumber",
                table: "InformationAboutEducations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "AssignedCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_AssignedCategoriesId",
                table: "InformationAboutEducations",
                column: "AssignedCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategoriesId",
                table: "InformationAboutEducations",
                column: "AssignedCategoriesId",
                principalTable: "AssignedCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategoriesId",
                table: "InformationAboutEducations");

            migrationBuilder.DropTable(
                name: "AssignedCategories");

            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_AssignedCategoriesId",
                table: "InformationAboutEducations");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "PersonalInformationOfStudents");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "PersonalInformationOfStudents");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "PersonalInformationOfStudents");

            migrationBuilder.RenameColumn(
                name: "AssignedCategoriesId",
                table: "InformationAboutEducations",
                newName: "AssignedCategories");

            migrationBuilder.AlterColumn<int>(
                name: "Organization",
                table: "SendingOrganizations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Snils",
                table: "PersonalInformationOfStudents",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "PersonalInformationOfStudents",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Series",
                table: "KindOfDocuments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "KindOfDocuments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfIssue",
                table: "KindOfDocuments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartOfEducation",
                table: "InformationAboutEducations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "ProtocolNumber",
                table: "InformationAboutEducations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndOfEducation",
                table: "InformationAboutEducations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "ContractNumber",
                table: "InformationAboutEducations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

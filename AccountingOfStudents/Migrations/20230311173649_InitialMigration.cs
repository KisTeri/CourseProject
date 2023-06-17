using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationalPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindOfProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KindOfDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Series = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KindOfDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformationOfStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Snils = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformationOfStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendingOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendingOrganizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationAboutEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    EducationalProgramsId = table.Column<int>(type: "int", nullable: false),
                    StartOfEducation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfEducation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProtocolNumber = table.Column<int>(type: "int", nullable: false),
                    AssignedCategories = table.Column<int>(type: "int", nullable: false),
                    PersonalInformationOfStudentsId = table.Column<int>(type: "int", nullable: false),
                    KindOfDocumentsId = table.Column<int>(type: "int", nullable: false),
                    SendingOrganizationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAboutEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InformationAboutEducations_EducationalPrograms_EducationalProgramsId",
                        column: x => x.EducationalProgramsId,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InformationAboutEducations_KindOfDocuments_KindOfDocumentsId",
                        column: x => x.KindOfDocumentsId,
                        principalTable: "KindOfDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InformationAboutEducations_PersonalInformationOfStudents_PersonalInformationOfStudentsId",
                        column: x => x.PersonalInformationOfStudentsId,
                        principalTable: "PersonalInformationOfStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganizationsId",
                        column: x => x.SendingOrganizationsId,
                        principalTable: "SendingOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_EducationalProgramsId",
                table: "InformationAboutEducations",
                column: "EducationalProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_KindOfDocumentsId",
                table: "InformationAboutEducations",
                column: "KindOfDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentsId",
                table: "InformationAboutEducations",
                column: "PersonalInformationOfStudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_SendingOrganizationsId",
                table: "InformationAboutEducations",
                column: "SendingOrganizationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformationAboutEducations");

            migrationBuilder.DropTable(
                name: "EducationalPrograms");

            migrationBuilder.DropTable(
                name: "KindOfDocuments");

            migrationBuilder.DropTable(
                name: "PersonalInformationOfStudents");

            migrationBuilder.DropTable(
                name: "SendingOrganizations");
        }
    }
}

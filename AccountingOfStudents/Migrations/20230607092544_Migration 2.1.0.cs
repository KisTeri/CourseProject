using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration210 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentId",
                table: "InformationAboutEducations");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentId",
                table: "InformationAboutEducations",
                column: "PersonalInformationOfStudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentId",
                table: "InformationAboutEducations");

            migrationBuilder.CreateIndex(
                name: "IX_InformationAboutEducations_PersonalInformationOfStudentId",
                table: "InformationAboutEducations",
                column: "PersonalInformationOfStudentId",
                unique: true);
        }
    }
}

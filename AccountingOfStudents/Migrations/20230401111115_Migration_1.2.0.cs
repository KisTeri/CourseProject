using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_120 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganizationsId",
                table: "InformationAboutEducations");

            migrationBuilder.RenameColumn(
                name: "SendingOrganizationsId",
                table: "InformationAboutEducations",
                newName: "SendingOrganization");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_SendingOrganizationsId",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_SendingOrganization");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations",
                column: "SendingOrganization",
                principalTable: "SendingOrganizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations");

            migrationBuilder.RenameColumn(
                name: "SendingOrganization",
                table: "InformationAboutEducations",
                newName: "SendingOrganizationsId");

            migrationBuilder.RenameIndex(
                name: "IX_InformationAboutEducations_SendingOrganization",
                table: "InformationAboutEducations",
                newName: "IX_InformationAboutEducations_SendingOrganizationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganizationsId",
                table: "InformationAboutEducations",
                column: "SendingOrganizationsId",
                principalTable: "SendingOrganizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

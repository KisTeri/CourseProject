using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingOfStudents.Migrations
{
    /// <inheritdoc />
    public partial class Migration_140 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations");

            migrationBuilder.AlterColumn<int>(
                name: "SendingOrganization",
                table: "InformationAboutEducations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedCategory",
                table: "InformationAboutEducations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations",
                column: "AssignedCategory",
                principalTable: "AssignedCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations",
                column: "SendingOrganization",
                principalTable: "SendingOrganizations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations");

            migrationBuilder.AlterColumn<int>(
                name: "SendingOrganization",
                table: "InformationAboutEducations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignedCategory",
                table: "InformationAboutEducations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_AssignedCategories_AssignedCategory",
                table: "InformationAboutEducations",
                column: "AssignedCategory",
                principalTable: "AssignedCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InformationAboutEducations_SendingOrganizations_SendingOrganization",
                table: "InformationAboutEducations",
                column: "SendingOrganization",
                principalTable: "SendingOrganizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

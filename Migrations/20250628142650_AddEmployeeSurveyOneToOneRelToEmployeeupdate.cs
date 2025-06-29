using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSurveyOneToOneRelToEmployeeupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSurvey_Employees_EmployeeId",
                table: "EmployeeSurvey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSurvey",
                table: "EmployeeSurvey");

            migrationBuilder.RenameTable(
                name: "EmployeeSurvey",
                newName: "EmployeeSurveys");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSurvey_EmployeeId",
                table: "EmployeeSurveys",
                newName: "IX_EmployeeSurveys_EmployeeId");

            migrationBuilder.AlterColumn<double>(
                name: "SleepHours",
                table: "EmployeeSurveys",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "PhysicalActivityHours",
                table: "EmployeeSurveys",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSurveys",
                table: "EmployeeSurveys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSurveys_Employees_EmployeeId",
                table: "EmployeeSurveys",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSurveys_Employees_EmployeeId",
                table: "EmployeeSurveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSurveys",
                table: "EmployeeSurveys");

            migrationBuilder.RenameTable(
                name: "EmployeeSurveys",
                newName: "EmployeeSurvey");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSurveys_EmployeeId",
                table: "EmployeeSurvey",
                newName: "IX_EmployeeSurvey_EmployeeId");

            migrationBuilder.AlterColumn<int>(
                name: "SleepHours",
                table: "EmployeeSurvey",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "PhysicalActivityHours",
                table: "EmployeeSurvey",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSurvey",
                table: "EmployeeSurvey",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSurvey_Employees_EmployeeId",
                table: "EmployeeSurvey",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

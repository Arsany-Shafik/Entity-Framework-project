using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredPrecedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE PROCEDURE SelectAllEmployeeNames 
        AS
        SELECT * FROM Employees 
        GO;
        ");
            migrationBuilder.Sql(@"
        CREATE PROCEDURE SelectAllEmployeeSurveys 
        AS
        SELECT * FROM EmployeeSurveys
        GO;
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE SelectAllEmployeeNames");
            migrationBuilder.Sql("DROP PROCEDURE SelectAllEmployeeSurveys");
        }
    }
}

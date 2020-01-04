using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreMvcCrud.Migrations
{
    public partial class AddedDeptField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employees",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employees");
        }
    }
}

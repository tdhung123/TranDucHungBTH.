using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranDucHungBTH2.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    MaNV = table.Column<string>(type: "TEXT", nullable: true),
                    phongban = table.Column<string>(type: "TEXT", nullable: true),
                    tên = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tranduchungBTTH2.Migrations
{
    public partial class age_sinhvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "sinhvien",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "sinhvien");
        }
    }
}

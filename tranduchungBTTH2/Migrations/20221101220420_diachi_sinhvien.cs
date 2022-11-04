using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tranduchungBTTH2.Migrations
{
    public partial class diachi_sinhvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "diachi",
                table: "sinhvien",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diachi",
                table: "sinhvien");
        }
    }
}

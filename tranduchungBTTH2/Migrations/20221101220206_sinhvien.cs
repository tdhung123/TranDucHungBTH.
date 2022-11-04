using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tranduchungBTTH2.Migrations
{
    public partial class sinhvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sinhvien",
                columns: table => new
                {
                    masinhvien = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    tensinhvien = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhvien", x => x.masinhvien);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhvien");
        }
    }
}

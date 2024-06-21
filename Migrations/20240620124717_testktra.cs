using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThiLai.Migrations
{
    /// <inheritdoc />
    public partial class testktra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "testktra",
                columns: table => new
                {
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    Lop = table.Column<string>(type: "TEXT", nullable: false),
                    SinhVien = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testktra", x => x.Ten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "testktra");
        }
    }
}

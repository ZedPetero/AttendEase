using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Brevi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedAttendancecWeights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceWeights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PresentWeight = table.Column<double>(type: "REAL", nullable: false),
                    LateWeight = table.Column<double>(type: "REAL", nullable: false),
                    AbsentWeight = table.Column<double>(type: "REAL", nullable: false),
                    ExcusedWeight = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceWeights", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceWeights");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedTeacherPic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Teachers",
                type: "BLOB",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Teachers");
        }
    }
}

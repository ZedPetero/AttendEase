using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changedSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeSchedule",
                table: "Sections",
                newName: "StartTimeSchedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTimeSchedule",
                table: "Sections",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTimeSchedule",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "StartTimeSchedule",
                table: "Sections",
                newName: "TimeSchedule");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppRedo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedReminders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeFrames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodicName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFrames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    HasAlarms = table.Column<bool>(type: "bit", nullable: true),
                    AlarmTime = table.Column<DateOnly>(type: "date", nullable: true),
                    AlarmDate = table.Column<TimeOnly>(type: "time", nullable: true),
                    Periodic = table.Column<bool>(type: "bit", nullable: true),
                    TimeFrameId = table.Column<int>(type: "int", nullable: true),
                    TimeFramesId = table.Column<int>(type: "int", nullable: true),
                    PeriodicDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PeriodicTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminders_TimeFrames_TimeFrameId",
                        column: x => x.TimeFrameId,
                        principalTable: "TimeFrames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_TimeFrameId",
                table: "Reminders",
                column: "TimeFrameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "TimeFrames");
        }
    }
}

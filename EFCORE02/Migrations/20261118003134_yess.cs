using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE02.Migrations
{
    /// <inheritdoc />
    public partial class yess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendee",
                columns: table => new
                {
                    AttendeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendee", x => x.AttendeeId);
                });

            migrationBuilder.CreateTable(
                name: "EventOrganizers",
                columns: table => new
                {
                    EventOrganizerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    EventStatus = table.Column<int>(type: "int", nullable: false),
                    OrganizerProfile_Biogarphy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerProfile_LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerProfile_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOrganizers", x => x.EventOrganizerId);
                });

            migrationBuilder.CreateTable(
                name: "Badge",
                columns: table => new
                {
                    BadgeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BadgeTier = table.Column<int>(type: "int", nullable: false),
                    AttId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badge", x => x.BadgeId);
                    table.ForeignKey(
                        name: "FK_Badge_Attendee_AttId",
                        column: x => x.AttId,
                        principalTable: "Attendee",
                        principalColumn: "AttendeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfAttendees = table.Column<int>(type: "int", nullable: false),
                    OrganizerProfileID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_EventOrganizers_OrganizerProfileID",
                        column: x => x.OrganizerProfileID,
                        principalTable: "EventOrganizers",
                        principalColumn: "EventOrganizerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badge_AttId",
                table: "Badge",
                column: "AttId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerProfileID",
                table: "Events",
                column: "OrganizerProfileID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badge");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Attendee");

            migrationBuilder.DropTable(
                name: "EventOrganizers");
        }
    }
}

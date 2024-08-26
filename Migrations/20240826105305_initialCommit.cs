using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTrainer.Migrations
{
    /// <inheritdoc />
    public partial class initialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingDone",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Distance = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeTaken = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDone", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingToDo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Distance = table.Column<int>(type: "INTEGER", nullable: false),
                    Time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingToDo", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingDone");

            migrationBuilder.DropTable(
                name: "TrainingToDo");
        }
    }
}

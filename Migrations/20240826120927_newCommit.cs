using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTrainer.Migrations
{
    /// <inheritdoc />
    public partial class newCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeOfTraining",
                table: "TrainingToDo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfTraining",
                table: "TrainingDone",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfTraining",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "TypeOfTraining",
                table: "TrainingDone");
        }
    }
}

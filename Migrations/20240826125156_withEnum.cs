using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTrainer.Migrations
{
    /// <inheritdoc />
    public partial class withEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExerciseType",
                table: "TrainingToDo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseType",
                table: "TrainingDone",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExerciseType",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "ExerciseType",
                table: "TrainingDone");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTrainer.Migrations
{
    /// <inheritdoc />
    public partial class FinalisedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "ExerciseType",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "TypeOfTraining",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "TypeOfTraining",
                table: "TrainingDone");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "TrainingToDo",
                newName: "SwimTime");

            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "TrainingToDo",
                newName: "SwimDistance");

            migrationBuilder.AddColumn<int>(
                name: "CycleDistance",
                table: "TrainingToDo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CycleTime",
                table: "TrainingToDo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RunDistance",
                table: "TrainingToDo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RunTime",
                table: "TrainingToDo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CycleDistance",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "CycleTime",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "RunDistance",
                table: "TrainingToDo");

            migrationBuilder.DropColumn(
                name: "RunTime",
                table: "TrainingToDo");

            migrationBuilder.RenameColumn(
                name: "SwimTime",
                table: "TrainingToDo",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "SwimDistance",
                table: "TrainingToDo",
                newName: "Distance");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "TrainingToDo",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "ExerciseType",
                table: "TrainingToDo",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
    }
}

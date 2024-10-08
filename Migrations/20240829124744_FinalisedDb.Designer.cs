﻿// <auto-generated />
using System;
using EventTrainer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventTrainer.Migrations
{
    [DbContext(typeof(TrainerContext))]
    [Migration("20240829124744_FinalisedDb")]
    partial class FinalisedDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("EventTrainer.Models.TrainingDone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Distance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExerciseType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeTaken")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("TrainingDone");
                });

            modelBuilder.Entity("EventTrainer.Models.TrainingToDo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CycleDistance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CycleTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RunDistance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RunTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SwimDistance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SwimTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("TrainingToDo");
                });
#pragma warning restore 612, 618
        }
    }
}

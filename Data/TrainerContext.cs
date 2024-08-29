using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventTrainer.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventTrainer.Data
{
    public class TrainerContext : DbContext
    {
        public TrainerContext (DbContextOptions<TrainerContext> options)
            : base(options)
        {
        }
        public DbSet<EventTrainer.Models.TrainingDone> TrainingDone { get; set; } = default!;
        public DbSet<EventTrainer.Models.TrainingToDo> TrainingToDo { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<TrainingDone>()
                .Property(t => t.ExerciseType)
                .HasConversion(new EnumToStringConverter<TrainingDone.TypeOfExercise>());
        }
    }
}

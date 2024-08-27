using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventTrainer.Data;
using EventTrainer.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventTrainer.Pages.Training
{
    public class IndexModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public IndexModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        public IList<TrainingDone> TrainingDone { get;set; } = default!;


        [BindProperty(SupportsGet = true)]
        public TrainingDone.TypeOfExercise SelectedExercise { get; set; }

        public SelectList Exercises { get; set; }


        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; } = "Date";


        public async Task OnGetAsync()
        {
            var Trainings = from c in _context.TrainingDone
                            select c;

            switch (SortField)
            {
                case "Date":
                    Trainings = Trainings.OrderBy(c => c.Date);
                    break;
                case "Exercise type":
                    Trainings = Trainings.OrderBy(c => c.ExerciseType);
                    break;
                case "Distance":
                    Trainings = Trainings.OrderBy(c => c.Distance);
                    break;
                case "Time":
                    Trainings = Trainings.OrderBy(c => c.TimeTaken);
                    break;
            }

            if (!SelectedExercise.Equals(null))
            {
                if (SelectedExercise == Models.TrainingDone.TypeOfExercise.Cycle)
                {
                    Trainings = Trainings.Where(c => c.ExerciseType == Models.TrainingDone.TypeOfExercise.Cycle);
                }
                else if (SelectedExercise == Models.TrainingDone.TypeOfExercise.Run)
                {
                    Trainings = Trainings.Where(c => c.ExerciseType == Models.TrainingDone.TypeOfExercise.Run);
                }
                else if (SelectedExercise == Models.TrainingDone.TypeOfExercise.Swim)
                {
                    Trainings = Trainings.Where(c => c.ExerciseType == Models.TrainingDone.TypeOfExercise.Swim);
                }
            }

            List<string> exerciseNames = Enum.GetValues(typeof(TrainingDone.TypeOfExercise))
                                         .Cast<TrainingDone.TypeOfExercise>()
                                         .Select(e => e.ToString())
                                         .ToList();

            Exercises = new SelectList(exerciseNames);

            TrainingDone = await Trainings.ToListAsync();
        }

    }
}

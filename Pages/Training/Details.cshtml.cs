using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventTrainer.Data;
using EventTrainer.Models;

namespace EventTrainer.Pages.Training
{
    public class DetailsModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public DetailsModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        public TrainingDone TrainingDone { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingdone = await _context.TrainingDone.FirstOrDefaultAsync(m => m.ID == id);
            if (trainingdone == null)
            {
                return NotFound();
            }
            else
            {
                TrainingDone = trainingdone;
            }
            return Page();
        }
    }
}

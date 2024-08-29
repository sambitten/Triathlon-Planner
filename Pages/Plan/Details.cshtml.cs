using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventTrainer.Data;
using EventTrainer.Models;

namespace EventTrainer.Pages.Plan
{
    public class DetailsModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public DetailsModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        public TrainingToDo TrainingToDo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingtodo = await _context.TrainingToDo.FirstOrDefaultAsync(m => m.ID == id);
            if (trainingtodo == null)
            {
                return NotFound();
            }
            else
            {
                TrainingToDo = trainingtodo;
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventTrainer.Data;
using EventTrainer.Models;

namespace EventTrainer.Pages.Training
{
    public class EditModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public EditModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TrainingDone TrainingDone { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingdone =  await _context.TrainingDone.FirstOrDefaultAsync(m => m.ID == id);
            if (trainingdone == null)
            {
                return NotFound();
            }
            TrainingDone = trainingdone;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TrainingDone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingDoneExists(TrainingDone.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TrainingDoneExists(int id)
        {
            return _context.TrainingDone.Any(e => e.ID == id);
        }
    }
}

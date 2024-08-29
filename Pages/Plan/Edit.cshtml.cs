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

namespace EventTrainer.Pages.Plan
{
    public class EditModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public EditModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TrainingToDo TrainingToDo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingtodo =  await _context.TrainingToDo.FirstOrDefaultAsync(m => m.ID == id);
            if (trainingtodo == null)
            {
                return NotFound();
            }
            TrainingToDo = trainingtodo;
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

            _context.Attach(TrainingToDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingToDoExists(TrainingToDo.ID))
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

        private bool TrainingToDoExists(int id)
        {
            return _context.TrainingToDo.Any(e => e.ID == id);
        }
    }
}

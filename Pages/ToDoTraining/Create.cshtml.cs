using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventTrainer.Data;
using EventTrainer.Models;

namespace EventTrainer.Pages.ToDoTraining
{
    public class CreateModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public CreateModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TrainingToDo TrainingToDo { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TrainingToDo.Add(TrainingToDo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

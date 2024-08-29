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
    public class IndexModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public IndexModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        public IList<TrainingToDo> TrainingToDo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TrainingToDo = await _context.TrainingToDo.ToListAsync();
        }
    }
}

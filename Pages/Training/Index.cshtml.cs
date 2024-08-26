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
    public class IndexModel : PageModel
    {
        private readonly EventTrainer.Data.TrainerContext _context;

        public IndexModel(EventTrainer.Data.TrainerContext context)
        {
            _context = context;
        }

        public IList<TrainingDone> TrainingDone { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TrainingDone = await _context.TrainingDone.ToListAsync();
        }
    }
}

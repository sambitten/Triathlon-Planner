using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EventTrainer.Pages.Shared
{
    public class _ProgressCirclePartialModel : PageModel
    {
        public required string BackgroundStroke { get; set; }
        public required string ForegroundStroke { get; set; }
        public double PercentProgress { get; set; }
        public double DisplayNumber { get; set; }
        public required string Unit { get; set; }
        public required string IconUrl { get; set; }
    }
}

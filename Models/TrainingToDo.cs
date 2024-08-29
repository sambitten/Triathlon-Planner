using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventTrainer.Models
{
    public class TrainingToDo
    {
        public int ID { get; set; }

        [Display(Name = "Cycling Distance (Kilometres)")]
        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        public int CycleDistance { get; set; }


        [Display(Name = "Cycling Time (Minutes)")]
        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        public int CycleTime  { get; set; }


        [Display(Name = "Swimming Distance (Kilometres)")]
        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        public int SwimDistance { get; set; }


        [Display(Name = "Swimming Time (Minutes)")]
        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        public int SwimTime { get; set; }


        [Display(Name = "Running Distance (Kilometres)")]
        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        public int RunDistance { get; set; }


        [Display(Name = "Running Time (Minutes)")]
        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        public int RunTime { get; set; }
    }
}

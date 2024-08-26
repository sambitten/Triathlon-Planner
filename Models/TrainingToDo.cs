using System.ComponentModel.DataAnnotations;

namespace EventTrainer.Models
{
    public class TrainingToDo
    {     
        public int ID { get; set; }

        [Required]
        public DateOnly Date {  get; set; } 

        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        [Required]
        public int Distance { get; set; }   

        [Range(1, 100000, ErrorMessage = "please enter a value between 1 & 100000")]
        [Required]
        public int Time { get; set; }

        public TypeOfExercise ExerciseType { get; set; }

        public enum TypeOfExercise
        {
            Cycle = 1,
            Run = 2,
            Swim = 3
        }
    }
}

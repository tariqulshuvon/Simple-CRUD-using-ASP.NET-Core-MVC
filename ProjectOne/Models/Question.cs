using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        [Required]
        public int QuestionMark { get; set; }

        public int ExamId { get; set; }
        public Exam? Exam { get; set; }
    }
}

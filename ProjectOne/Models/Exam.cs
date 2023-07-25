namespace ProjectOne.Models
{
    public class Exam:Base
    {
        public int ExamId { get; set; }
        public int? TotalMark { get; set; }

        public IEnumerable<Question>? Questions { get; set; }
    }
}

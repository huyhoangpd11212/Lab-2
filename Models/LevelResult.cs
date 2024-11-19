using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class LevelResult
    {
        [Key]
        public int QuizResult {  get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Level")]
        public int LevelId { get; set; }
        public int Score { get; set; }
        public DateOnly CompletionDate { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class Base
    {
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(15)]
        public string? Phone { get; set; }
        [Required]
        [MaxLength (100)]
        public string? Email { get; set; }
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public DateTimeOffset UpdateTime { get; set;}
    }
}

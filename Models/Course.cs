using System.ComponentModel.DataAnnotations;

namespace lldb.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
    }
}

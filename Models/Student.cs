using System.ComponentModel.DataAnnotations;

namespace db.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1, 150)]

        public string Age { get; set; }
        [MaxLength(500)]

        public string Address { get; set; }
    }
}

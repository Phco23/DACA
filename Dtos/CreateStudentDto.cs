using System.ComponentModel;

namespace lldb.Dtos
{
    public class CreateStudentDto
    {
        [DisplayName("Student name")]
        public string Name { get; set; }
        [DisplayName("Student age")]
        public int Age { get; set; }
        [DisplayName("Student address")]
        public string Address { get; set; }
        [DisplayName("Student ClassId")]
        public int ClassId { get; set; }
    }
}

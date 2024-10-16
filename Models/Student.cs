using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lldb.Models
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		[Range(18, 30, ErrorMessage = "Only 18 - 30 yrs old can accept")]
		public int Age { get; set; }
		[MaxLength(200, ErrorMessage = "Can not great than 200 keyword")]
		public string Address { get; set; }
		[ForeignKey("ClassId")]
		public int ClassId { get; set; }
		public Class Class { get; set; }
	}
}

using System.ComponentModel.DataAnnotations;

namespace db.Models
{
    public class Class
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string ClassName { get; set; }

        public string RoomName { get; set; }
    }
}

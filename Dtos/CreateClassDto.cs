using System.ComponentModel;

namespace lldb.Dtos
{
    public class CreateClassDto
    {
        [DisplayName("Class name")]
        public string ClassName { get; set; }
        [DisplayName("Room name")]
        public string RoomName { get; set; }
    }
}

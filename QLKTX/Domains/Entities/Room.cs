using System.Collections.Generic;

namespace QLKTX.Domains.Entities
{
    public class Room : Entity
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

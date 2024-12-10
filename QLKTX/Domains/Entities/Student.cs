namespace QLKTX.Domains.Entities
{
    public class Student : Entity
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}

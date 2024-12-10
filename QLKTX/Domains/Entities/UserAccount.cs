namespace QLKTX.Domains.Entities
{
    public class UserAccount : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
    }
}

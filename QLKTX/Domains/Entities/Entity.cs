using System.ComponentModel.DataAnnotations;

namespace QLKTX.Domains.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public double CreatedDateTS { get; set; }
        public bool IsDeleted { get; set; }
        public double UpdatedDateTS { get; set; }
    }
}

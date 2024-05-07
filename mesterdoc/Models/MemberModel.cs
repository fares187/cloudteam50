using System.ComponentModel.DataAnnotations;

namespace mesterdoc.Models
{
    public class MemberModel
    {
        [Key]
        public int Id { get; set; }
        public string MemberName { get; set; }
        public int Age { get; set; }    
        public double CGPA { get; set; }    
        public string? Image { get;set; }
    }
}

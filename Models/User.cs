using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookCart.Models
{
    public class User
    {

        [Key]

        [Column("Id")]

        public int Id { get; set; }

[Column(TypeName = "nvarchar(100)")]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public int Roleld {get; set; }
        [ForeignKey("Roleld")]
        public Role? Role { get; set; }

    }
}


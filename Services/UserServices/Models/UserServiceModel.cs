using System.ComponentModel.DataAnnotations;

namespace UsersService.Models
{
    public class UserServiceModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = null!;

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserType { get; set; } = "User";

    }
}

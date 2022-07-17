using System.ComponentModel.DataAnnotations;

namespace InputModels.UserInputModels
{
    public class UserInputModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        public string Password { get; set; } = null!;

        [MaxLength(320)]
        public string? Email { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
    }
}

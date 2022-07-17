namespace ResponseModels.UserResponseModels
{
    public class UserResponseModel
    {
        public string Name { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
    }
}

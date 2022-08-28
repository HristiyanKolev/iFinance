namespace ResponseModels.UserResponseModels
{
    public class UserResponseModel
    {
        public int Id { get; set; }

        public string UserName { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public string UserType { get; set; } = null!;
    }
}

using Moq;
using UsersService.Models;
using UsersServices.Contracts;

namespace UsersServicesTests
{
    public class UserServiceTests
    {
        List<UserServiceModel> usersCollection = new List<UserServiceModel>()
        {
            new UserServiceModel { Id = 0, UserName = "HristiyanKolev", UserType = "admin", DateCreated = DateTime.Now },
            new UserServiceModel { Id = 1, UserName = "StanRangelov", UserType = "user", DateCreated = DateTime.Now },
            new UserServiceModel { Id = 2, UserName = "GeorgiHorozov", UserType = "premium", DateCreated = DateTime.Now }
        };
        List<UserServiceModel> emptyCollection = new List<UserServiceModel>() { };

        Mock<IUserService> mockService = new Mock<IUserService>();

        [Fact]
        public void Return_Collection_Of_Users()
        {
            // Arrange
            mockService.Setup(p => p.GetUsers()).Returns(usersCollection);

            // Act
            IEnumerable<UserServiceModel> users = mockService.Object.GetUsers();

            // Assert
            mockService.Verify(u => u.GetUsers());
            Assert.Equal(3, users.Count());
        }

        [Fact]
        public void Return_Empty_Collection_Of_Users()
        {
            // Arrange
            mockService.Setup(p => p.GetUsers()).Returns(emptyCollection);

            // Act
            IEnumerable<UserServiceModel> users = mockService.Object.GetUsers();

            // Assert
            mockService.Verify(u => u.GetUsers());
            Assert.Empty(users);
        }

        [Fact]
        public void Returns_Valid_User_With_Matching_ID()
        {
            // Arrange
            mockService.Setup(p => p.GetUserByID(0)).Returns(usersCollection.FirstOrDefault(x => x.Id == 0));

            // Act
            UserServiceModel user = mockService.Object.GetUserByID(0);

            // Assert
            mockService.Verify(u => u.GetUserByID(0));
            Assert.Equal(0, user.Id);
            Assert.Equal("HristiyanKolev", user.UserName);
            Assert.Equal("admin", user.UserType);
        }                
    }
} 
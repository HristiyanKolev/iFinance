using AutoMapper;

using InputModels.UserInputModels;
using UsersService.Models;
using ResponseModels.UserResponseModels;

namespace iFinanceAPI.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserInputModel, UserServiceModel>();
            CreateMap<UserServiceModel, UserResponseModel>();
        } 
    }
}

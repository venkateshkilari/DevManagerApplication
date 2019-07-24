using BusinessEntity.Implementation.User;
using DTO.Implementation.User;

namespace BusinessLogic.MapperProfiles
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, UserBE>().ReverseMap();
        }
    }
}

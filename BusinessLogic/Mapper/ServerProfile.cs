using BusinessEntity.Implementation.Devops;
using DTO.Implementation.Devops;

namespace BusinessLogic.MapperProfiles
{
    public class ServerProfile : AutoMapper.Profile
    {
        public ServerProfile()
        {
            CreateMap<ServerDTO, ServerBE>().ReverseMap();
        }
    }
}

using BusinessEntity.Implementation.Devops;
using DTO.Implementation.Devops;

namespace BusinessLogic.MapperProfiles
{
    public class DevopsProfile:AutoMapper.Profile
    {
        public DevopsProfile()
        {
            CreateMap<DevopsDTO, DevopsBE>().ReverseMap();
        }
    }
}

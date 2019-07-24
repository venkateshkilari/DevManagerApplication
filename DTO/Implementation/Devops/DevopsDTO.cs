using DTO.Interface.Devops;
using System.Collections.Generic;

namespace DTO.Implementation.Devops
{
    public class DevopsDTO: EntityDTO<string>, IDevopsDTO
    {
        public List<ServerDTO> Servers { get; set; }
    }
}

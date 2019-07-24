using DTO.Implementation.User;
using DTO.Interface.Devops;
using static Utility.Constants.EnumConstants;

namespace DTO.Implementation.Devops
{
    public class ServerDTO:EntityDTO<string>,IServerDTO
    {
        public string Name { get; set; }
        public ServerStatus Status { get; set; }
        public UserDTO User { get; set; }
    }
}

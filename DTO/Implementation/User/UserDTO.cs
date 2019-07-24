using DTO.Interface.User;

namespace DTO.Implementation.User
{
    public class UserDTO:EntityDTO<string>,IUserDTO
    {
        public string Name { get; set; }
    }
}

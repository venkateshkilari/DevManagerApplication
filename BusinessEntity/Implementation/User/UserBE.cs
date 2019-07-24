using BusinessEntity.Interface.User;

namespace BusinessEntity.Implementation.User
{
    public class UserBE:EntityBE<string>,IUserBE
    {
        public string Name { get; set; }
    }
}

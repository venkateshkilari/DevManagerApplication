using BusinessEntity.Implementation.User;
using BusinessEntity.Interface.Devops;
using static Utility.Constants.EnumConstants;

namespace BusinessEntity.Implementation.Devops
{
    public class ServerBE:EntityBE<string>,IServerBE
    {
        public string Name { get; set; }
        public ServerStatus Status { get; set; }
        public UserBE User { get; set; }
    }
}

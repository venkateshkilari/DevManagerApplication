using DTO.Implementation.Devops;

namespace BusinessLogic.Interface.Devops
{
    public interface IDevopsService
    {
        DevopsDTO GetServerDetails();
        void BlockServer(string serverName, string user);
        void ReleaseServer(string serverName);
    }
}

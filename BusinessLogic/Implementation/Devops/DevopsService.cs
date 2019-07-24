using AutoMapper;
using BusinessEntity.Implementation.Devops;
using BusinessEntity.Implementation.User;
using BusinessLogic.Interface.Devops;
using DTO.Implementation.Devops;
using Newtonsoft.Json;
using Ninject;
using Repository.Interface.Devops;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using static Utility.Constants.EnumConstants;

namespace BusinessLogic.Implementation.Devops
{
    public class DevopsService:ServiceBase<string,DevopsBE,DevopsDTO>,IDevopsService
    {
        private readonly IDevopsRepository _devopsRepository;
        public DevopsService(IKernel kernal,IMapper mapper):base(kernal,mapper)
        {
            _devopsRepository = _repository as IDevopsRepository;
        }

        public DevopsDTO GetServerDetails()
        {
            
            return ConvertToDTO(GetDetails());
        }

        public void BlockServer(string serverName,string user)
        {
            var devops = GetDetails();
            var server = devops.Servers.FirstOrDefault(x => x.Name == serverName);
            server.Name = serverName;
            server.Status = ServerStatus.Blocked;
            server.User = new UserBE {
                            Name = user
                           };
            _devopsRepository.Add(devops);
        }


        public void ReleaseServer(string serverName)
        {
            var devops = GetDetails();
            var server = devops.Servers.FirstOrDefault(x => x.Name == serverName);
            server.Name = serverName;
            server.Status = ServerStatus.Released;
            server.User = null;
            _devopsRepository.Add(devops);
        }

        private DevopsBE GetDetails()
        {
            DevopsBE devops = new DevopsBE { Servers = JsonConvert.DeserializeObject<List<ServerBE>>(ConfigurationManager.AppSettings["ServerData"]) };
            var cacheData = _devopsRepository.Get();
            if (cacheData != null && cacheData.Servers != null && cacheData.Servers.Count > 0)
            {
                devops.Servers.RemoveAll(x => cacheData.Servers.Exists(y => y.Name == x.Name));
                devops.Servers.AddRange(cacheData.Servers);
            }

            return devops;
        } 



    }
}

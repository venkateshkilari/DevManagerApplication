using BusinessEntity.Implementation.Devops;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Repository.Implementation.Devops;
using Repository.Interface.Devops;
using RepositoryTests.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utility.Constants.EnumConstants;

namespace Repository.Implementation.Devops.Tests
{
    [TestClass()]
    public class DevopsRepositoryTests
    {
        private IDevopsRepository _repository;
        public DevopsRepositoryTests()
        {
            IKernel kernal = Ioc.Initilize();
            _repository = kernal.Get<IDevopsRepository>();
        }

        [TestMethod()]
        public void AddTest()
        {
            _repository.Add(new DevopsBE
            {
                Servers = new List<ServerBE>
                {
                    new ServerBE
                    {
                        Id = "1",
                        Name = "DevApp",
                        Status = ServerStatus.Blocked                        
                    }
                }

            });
            var devops = _repository.Get();
            Assert.IsNotNull(devops);
        }

        
    }
}
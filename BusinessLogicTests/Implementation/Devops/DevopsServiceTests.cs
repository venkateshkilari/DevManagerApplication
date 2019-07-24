using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic.Implementation.Devops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using BusinessLogicTests.DependencyInjection;
using BusinessLogic.Interface.Devops;

namespace BusinessLogic.Implementation.Devops.Tests
{
    [TestClass()]
    public class DevopsServiceTests
    {
        private IDevopsService _service;
        public DevopsServiceTests()
        {
            IKernel kernal = Ioc.Initilize();
            _service = kernal.Get<IDevopsService>();
        }
        [TestMethod()]
        public void GetServerDetailsTest()
        {
            var serverDetails = _service.GetServerDetails();
            Assert.IsNotNull(serverDetails);
        }
        [TestMethod()]
        public void BlockServerTest()
        {
             _service.BlockServer("DevAppBox","Kilari");
            var serverDetails = _service.GetServerDetails();
            Assert.AreEqual(Utility.Constants.EnumConstants.ServerStatus.Blocked, serverDetails.Servers.FirstOrDefault(x=>x.Name=="DevAppBox").Status);
        }
        [TestMethod()]
        public void ReleaseServerTest()
        {
            _service.ReleaseServer("DevAppBox");
            var serverDetails = _service.GetServerDetails();
            Assert.AreEqual(Utility.Constants.EnumConstants.ServerStatus.Released, serverDetails.Servers.FirstOrDefault(x => x.Name == "DevAppBox").Status);
        }
    }
}
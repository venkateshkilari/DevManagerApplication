using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevManagerApplication.App_Start
{
    public class NinjectResolver : IDependencyResolver
    {
        private readonly IKernel _kernal;

        public NinjectResolver()
        {
            _kernal = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernal.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernal.GetAll(serviceType);
        }

        private void AddBindings()
        {
            this._kernal.Load("Repository.dll","BusinessLogic.dll","Database.dll");
        }
    }
}
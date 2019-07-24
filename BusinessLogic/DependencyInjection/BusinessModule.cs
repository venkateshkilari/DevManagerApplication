using BusinessLogic.Implementation.Devops;
using BusinessLogic.Interface.Devops;
using Ninject.Modules;

namespace BusinessLogic.DependencyInjection
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDevopsService>().To<DevopsService>();
        }
    }
}

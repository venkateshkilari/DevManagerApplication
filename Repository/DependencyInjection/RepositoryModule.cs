using BusinessEntity.Implementation.Devops;
using Ninject.Modules;
using Repository.Implementation.Devops;
using Repository.Interface;
using Repository.Interface.Devops;

namespace Repository.DependencyInjection
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDevopsRepository>().To<DevopsRepository>();
            Bind<IRepository<string, DevopsBE>>().To<DevopsRepository>();
        }
    }
}

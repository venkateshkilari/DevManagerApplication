using Database.Implementation;
using Database.Interface;
using Ninject.Modules;

namespace Database.DependencyInjection
{
    public class DatabaseModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationCacheDatabase>().To<ApplicationCacheDatabase>().InSingletonScope();
        }
    }
}

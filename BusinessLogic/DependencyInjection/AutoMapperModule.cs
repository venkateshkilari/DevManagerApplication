using AutoMapper;
using BusinessLogic.MapperProfiles;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;

namespace BusinessLogic.DependencyInjection
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(AutoMapper).InSingletonScope();
        }

        private IMapper AutoMapper(IContext context)
        {
            Mapper.Initialize(config =>
            {
                config.ConstructServicesUsing(type => context.Kernel.Get(type));
                config.AddProfile(new DevopsProfile());
                config.AddProfile(new ServerProfile());
                config.AddProfile(new UserProfile());

            });
            Mapper.AssertConfigurationIsValid();
            return Mapper.Instance;
        }
    }
}

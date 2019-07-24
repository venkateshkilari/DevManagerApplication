using BusinessLogic.DependencyInjection;
using Database.DependencyInjection;
using Ninject;
using Repository.DependencyInjection;

namespace BusinessLogicTests.DependencyInjection
{
    public class Ioc
    {
        public static IKernel Initilize()
        {
            return new StandardKernel(new BusinessModule(),new AutoMapperModule(),new RepositoryModule(), new DatabaseModule());
        }
    }
}

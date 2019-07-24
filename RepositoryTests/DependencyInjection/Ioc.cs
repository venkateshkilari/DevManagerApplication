using Database.DependencyInjection;
using Ninject;
using Repository.DependencyInjection;

namespace RepositoryTests.DependencyInjection
{
    public class Ioc
    {
        public static IKernel Initilize()
        {
            return new StandardKernel(new RepositoryModule(),new DatabaseModule());
        }
    }
}

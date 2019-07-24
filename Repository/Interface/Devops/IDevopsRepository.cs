using BusinessEntity;
using BusinessEntity.Implementation.Devops;
using BusinessEntity.Interface.Devops;

namespace Repository.Interface.Devops
{
    public interface IDevopsRepository: IRepository<string, DevopsBE>
    {
        void Add(DevopsBE devopsBE);
        DevopsBE Get();
    }
}

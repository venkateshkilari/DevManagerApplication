using BusinessEntity.Implementation;
using BusinessEntity.Interface;

namespace Repository.Interface
{
    public interface IRepository<TKey,TBE> where TBE:class,IEntityBE<TKey>
    {
    }
}

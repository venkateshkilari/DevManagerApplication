using BusinessEntity.Interface;
using DTO.Interface;

namespace BusinessLogic.Interface
{
    public interface IService<TKey,TBE,TDTO> where TBE:class,IEntityBE<TKey> 
                                             where TDTO:class,IEntityDTO<TKey>
    {
    }
}

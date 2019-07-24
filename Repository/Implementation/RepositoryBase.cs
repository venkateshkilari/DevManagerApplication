using BusinessEntity.Interface;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class RepositoryBase<TKey, TBE>: IRepository<TKey,TBE> where TBE : class, IEntityBE<TKey>
    {
    }
}

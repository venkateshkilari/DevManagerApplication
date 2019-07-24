using AutoMapper;
using BusinessEntity.Interface;
using BusinessLogic.Interface;
using DTO.Interface;
using Ninject;
using Repository.Interface;

namespace BusinessLogic.Implementation
{
    public class ServiceBase<TKey, TBE, TDTO>:IService<TKey, TBE, TDTO> where TBE : class, IEntityBE<TKey>
                                             where TDTO : class, IEntityDTO<TKey>
    {
        public IRepository<TKey, TBE> _repository;
        private IMapper _Mapper { get; set; }
        public ServiceBase(IKernel kernal, IMapper mapper)
        {
            _repository = kernal.Get<IRepository<TKey, TBE>>();
            _Mapper = mapper;
        }

        public TDTO ConvertToDTO(TBE tbe)
        {
            return _Mapper.Map<TBE, TDTO>(tbe);
        }

        public TBE ConvertToBE(TDTO tDTO)
        {
            return _Mapper.Map<TDTO, TBE>(tDTO);
        }
    }
}

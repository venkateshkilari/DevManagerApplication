using BusinessEntity.Interface;

namespace BusinessEntity.Implementation
{
    public class EntityBE<T>:IEntityBE<T>
    {
        public T Id { get; set; }
        
    }
}

using DTO.Interface;

namespace DTO.Implementation
{
    public class EntityDTO<TKey>:IEntityDTO<TKey>
    {
        public TKey Id { get; set; }
    }
}

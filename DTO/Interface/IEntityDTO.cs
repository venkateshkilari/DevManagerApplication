namespace DTO.Interface
{
    public interface IEntityDTO<TKey>
    {
        TKey Id { get; set; }
    }
}

namespace Campus.Core
{
    public interface IEntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}

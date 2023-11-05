namespace BlogSistemi.Entities.Entities
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }

    }
}

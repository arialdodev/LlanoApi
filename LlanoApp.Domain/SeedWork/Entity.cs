namespace LlanoApp.Domain.SeedWork
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime UpdateDate { get; private set; }
        public DateTime CreateDate { get; private set; }

        protected Entity()
        {
            UpdateDate = DateTime.Now;
            CreateDate = DateTime.Now;
        }
        public void SetUpdateDate()
        {
            UpdateDate = DateTime.UtcNow;
        }

    }
}

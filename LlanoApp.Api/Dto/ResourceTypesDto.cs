namespace LlanoApp.Api.Dto
{
    public class ResourceTypesDto 
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public ResourceTypesDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

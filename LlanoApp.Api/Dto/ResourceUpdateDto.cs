namespace LlanoApp.Api.Dto
{
    public class ResourceUpdateDto
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Id { get; set; }


        public ResourceUpdateDto(string name, string description, int id)
        {
            Name = name;
            Description = description;
            Id = id;
        }

    }
}

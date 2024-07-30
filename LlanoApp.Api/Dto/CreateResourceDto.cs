namespace LlanoApp.Api.Dto
{
    public class CreateResourceDto
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public int ResourceTypesId { get; private set; }


        public CreateResourceDto(string name, string description, string image ,int resourceTypesId)
        {
            Name = name;
            Description = description;
            Image = image;
            ResourceTypesId = resourceTypesId;
        }
    }
}

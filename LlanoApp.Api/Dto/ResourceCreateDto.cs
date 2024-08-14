namespace LlanoApp.Api.Dto
{
    public class ResourceCreateDto
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public int ResourceTypesId { get; private set; }

        public ResourceCreateDto(
            string name,
            string description,
            int resourceTypesId,
            string image = ""
        )
        {
            Name = name;
            Description = description;
            Image = image;
            ResourceTypesId = resourceTypesId;
        }

        public void SetName(string name) {
            this.Name = name;
        }

        public void SetDescription(string description)
        {
            this.Description = description;
        }
        public void SetImage(string image)
        {
            this.Image = image;
        }
    }
}

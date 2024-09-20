namespace LlanoApp.Api.Dto
{
    public class ResourceStatesDto
    {
        public int Id { get; private set; }
        public string NameState { get; private set; }

        public ResourceStatesDto(
            int id,
            string nameState
        )
        {
            Id = id;
            NameState = nameState;
        }
    }
}

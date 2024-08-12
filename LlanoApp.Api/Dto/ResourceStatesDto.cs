namespace LlanoApp.Api.Dto
{
    public class ResourceStatesDto
    {
        public int Id { get; private set; }
        public String State { get; private set; }

        public ResourceStatesDto(
            int id,
            String state
        )
        {
            Id = id;
            State = state;
        }
    }
}

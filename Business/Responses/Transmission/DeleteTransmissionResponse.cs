namespace Business.Responses.Transmission
{
    public class DeleteTransmissionResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeletedAt { get; set; }
        public DeleteTransmissionResponse(int id, string name, DateTime deletedAt)
        {
            Id = id;
            Name = name;
            DeletedAt = deletedAt;
        }
        public DeleteTransmissionResponse()
        {

        }
    }
}
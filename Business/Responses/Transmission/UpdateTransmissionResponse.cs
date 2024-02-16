namespace Business.Responses.Transmission
{
    public class UpdateTransmissionResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UpdateTransmissionResponse(int id, string name, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            UpdatedAt = updatedAt;
        }
        public UpdateTransmissionResponse()
        {

        }
    }
}
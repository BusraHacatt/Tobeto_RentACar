namespace Business.Request.Transmission
{
    public class DeleteTransmissionRequest
    {
        public int Id { get; set; }
        public DeleteTransmissionRequest(int id)
        {
            Id = id;
        }
    }
}

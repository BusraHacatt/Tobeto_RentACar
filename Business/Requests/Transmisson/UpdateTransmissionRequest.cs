namespace Business.Request.Transmission
{
    public class UpdateTransmissionRequest
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public UpdateTransmissionRequest(string name, int ıd)
        {
            Name = name;
            Id = ıd;
        }
    }
}
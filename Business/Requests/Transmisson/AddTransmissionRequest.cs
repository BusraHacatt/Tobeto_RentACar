namespace Business.Request.Transmission
{
    public class AddTransmissionRequest
    {
        public string Name { get; set; }
        public AddTransmissionRequest(string name)
        {
            Name = name;
        }
    }
}
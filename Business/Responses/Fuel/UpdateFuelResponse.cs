namespace Business.Responses.Fuel
{
    public class UpdateFuelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UpdateFuelResponse(int id, string name, DateTime updatedAd)
        {
            Id = id;
            Name = name;
            UpdatedAt = updatedAd;
        }
        public UpdateFuelResponse()
        {

        }
    }
}
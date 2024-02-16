namespace Business.Responses.Brand
{
    public class UpdateBrandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UpdateBrandResponse(int id, string name, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            UpdatedAt = updatedAt;
        }
        public UpdateBrandResponse()
        {

        }
    }
}
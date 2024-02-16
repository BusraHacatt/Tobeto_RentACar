namespace Business.Responses.Brand
{
    public class DeleteBrandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeletedAt { get; set; }
        public DeleteBrandResponse(int id, string name, DateTime deletedAt)
        {
            Id = id;
            Name = name;
            DeletedAt = deletedAt;
        }
        public DeleteBrandResponse()
        {

        }

    }
}
namespace Business.Request.Brand
{
    public class DeleteBrandRequest
    {
        public int Id { get; set; }
        public DeleteBrandRequest(int id)
        {
            Id = id;

        }
    }
}

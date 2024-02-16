namespace Business.Request.Model
{
    public class DeleteModelRequest
    {
        public int Id { get; set; }
        public DeleteModelRequest(int id)
        {
            Id = id;
        }
    }
}
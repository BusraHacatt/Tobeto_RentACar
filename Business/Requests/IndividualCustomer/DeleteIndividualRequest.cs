namespace Business.Request.IndividualCustomer
{
    public class DeleteIndividualRequest
    {
        public DeleteIndividualRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }

    }
}

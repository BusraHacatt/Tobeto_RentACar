namespace Business.Request.IndividualCustomer
{
    public class UpdateIndividualRequest
    {
        public UpdateIndividualRequest(int ıd, string firstName, string lastName, string nationalIdentity, int customerId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CustomerId = customerId;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public int CustomerId { get; set; }
    }
}
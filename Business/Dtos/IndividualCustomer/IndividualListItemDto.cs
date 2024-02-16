namespace Business.Dtos.IndividualCustomer
{
    public class IndividualListItemDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
        public int CustomerId { get; set; }
    }
}

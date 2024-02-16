namespace Business.Responses.User
{
    public class AddUserResponse
    {
        public AddUserResponse(int ıd, string firstName, string lastName, string email, string password, DateTime createdAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
        }
        public AddUserResponse()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

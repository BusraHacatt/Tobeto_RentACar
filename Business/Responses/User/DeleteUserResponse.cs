namespace Business.Responses.User
{
    public class DeleteUserResponse
    {
        public DeleteUserResponse(int ıd, string firstName, string lastName, string email, string password, DateTime deletedAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            DeletedAt = deletedAt;
        }
        public DeleteUserResponse()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
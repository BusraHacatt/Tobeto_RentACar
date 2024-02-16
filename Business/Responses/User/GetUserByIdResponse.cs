﻿namespace Business.Responses.User
{
    public class GetUserByIdResponse
    {
        public GetUserByIdResponse(int ıd, string firstName, string lastName, string email, string password)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public GetUserByIdResponse()
        {


        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
﻿using Core.CrossCuttingConcerns.Exceptions;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class UserBusinessRules
    {
        public void CheckIfUserExists(User? user)
        {
            if (user is null)
                throw new NotFoundException("User not found.");
        }
    }
}

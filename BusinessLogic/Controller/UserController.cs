using BusinessLogic.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    internal class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        // Handles user login request
        public User Login(string username, string password)
        {
            // Basic validation check before querying database
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            // Call repository to verify user
            return _userRepository.AuthenticateUser(username, password);
        }
    }
}

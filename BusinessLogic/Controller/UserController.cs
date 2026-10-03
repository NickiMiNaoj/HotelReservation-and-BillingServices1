using BusinessLogic.Repository;
using Model;
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

        public UserModel Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return _userRepository.AuthenticateUser(username, password);
        }
    }
}

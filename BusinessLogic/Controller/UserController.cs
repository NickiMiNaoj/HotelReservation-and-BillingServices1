using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    internal class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        public User Login(string username, string password)
        {
            // Basic validation check before querying database
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return _userRepository.AuthenticateUser(username, password);
        }
    }
}

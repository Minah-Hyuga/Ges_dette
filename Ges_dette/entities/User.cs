using System;

namespace Ges_dette.entities
{
    internal class User
    {
        private string _login;
        private string _email;
        private string _password;
        private Client _client;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
    }
}

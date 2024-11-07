using System;

namespace Ges_dette.entities
{
    internal class Client
    {
        private string _surname;
        private string _tel;
        private string _address;
        private User _user;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Booking.Com
{
    class User
    {
        Guid _id;
        string _firstName;
        string _lastName;
        string _email;
        string _login;
        string _password;

        public User()
        {
            this.Id = Guid.NewGuid();
            this.FirstName = "unknown";
            this.LastName = "unknown";
            this.Email = "unknown";
            this.Login = "unknown";
            this.Password = "unknown";
        }

        public User(string firstName, string lastName, string email, string login, string password)
        {
            _id = Guid.NewGuid();
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _login = login;
            _password = password;
        }

        public Guid Id { get => _id; private set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; private set => _password = value; }

        public void ShowUserInformation()
        {
            string pass = "***" + _password.Substring(_password.Length - 3);
            Console.WriteLine($"User ID: {_id}");
            Console.WriteLine($"User: {_firstName} {_lastName}");
            Console.WriteLine($"E-mail: {_email}");
            Console.WriteLine($"Login: {_login}");
            Console.WriteLine($"Password: {pass}");
            Console.WriteLine();
        }

        public void ChangePassword(string pass)
        {
            if (String.IsNullOrEmpty(pass))
            {
                Console.WriteLine("Password can't be empty");
                return;
            }
            if (pass == _password)
            {
                Console.WriteLine("Password can't be same");
                return;
            }
            _password = pass;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai3
{
    public class Profile
    {
        private int _age;
        private string _fullName;
        private string _email;
        private string _phone;
        private int _salary;
        private string _userName;
        private string _password;

        public int Age { get => _age; set => _age = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public int Salary { get => _salary; set => _salary = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }

        // Constructor for quick initialization
        public Profile(string fullName, string email, string phone, int age, int salary, string userName, string password)
        {
            _fullName = fullName;
            _email = email;
            _phone = phone;
            _age = age;
            _salary = salary;
            _userName = userName;
            _password = password;
        }
    }
}

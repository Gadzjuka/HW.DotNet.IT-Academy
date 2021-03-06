using System;
using System.Collections.Generic;
using System.Text;

namespace HW08.Task3.Interface
{
    class Junior : IEngineer
    {
        private static string _title = "Junior Developer";
        private static short _titleImportance = 0;
        private Guid _identifier;
        private string _firstName;
        private string _lastName;
        private byte _experience;
        private List<string> _responsibilities;
        private List<string> _technologies;
        private string _gitAccount;
        private string _company;        

        public Junior()
        {
            _identifier = Guid.NewGuid();
            _firstName = "unknown";
            _lastName = "unknown";
            _experience = 0;
            _responsibilities = new List<string>();
            _technologies = new List<string>();
            _gitAccount = "unknown";
            _company = "unknown";
        }
        public Junior(string first, string last, byte exp,
            List<string> resp, List<string> tech, string git, string company)
        {
            _identifier = Guid.NewGuid();
            _firstName = first;
            _lastName = last;
            _experience = exp;
            _responsibilities = resp;
            _technologies = tech;
            _gitAccount = git;
            _company = company;
        }

        public Guid Identifier { get => _identifier; set => _identifier = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public byte Experience { get => _experience; set => _experience = value; }
        public List<string> Responsibilities { get => _responsibilities; set => _responsibilities = value; }
        public List<string> Technologies { get => _technologies; set => _technologies = value; }
        public string GitAccount { get => _gitAccount; set => _gitAccount = value; }
        public string Company { get => _company; set => _company = value; }
        public string Title { get => _title; }
        public short TitleImportance { get => _titleImportance; }

        public virtual int GetSalary()
        {
            return IEngineer.baseSalary;
        }
        public string GetResponsibilities()
        {
            string responsibility = "";
            for (int i = 0; i < _responsibilities.Count; i++)
            {
                if (i == _responsibilities.Count - 1)
                {
                    responsibility += _responsibilities[i];
                    break;
                }
                responsibility += _responsibilities[i] + ", ";
            }
            return responsibility;
        }
        public void ShowInformation()
        {
            Console.WriteLine($"Company: {_company}, Full Name: {_firstName} {_lastName}, Experience: {_experience}, Title: {_title}");
            Console.WriteLine($"Salary: {GetSalary()}, GitHub: {_gitAccount}");
        }
    }
}

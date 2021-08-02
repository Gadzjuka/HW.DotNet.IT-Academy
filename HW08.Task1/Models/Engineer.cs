using System;
using System.Collections.Generic;
using System.Text;

namespace HW08.Task1.Models
{
    class Engineer
    {
        protected const short _baseSalary = 500;
        protected Guid _identifier;
        protected string _firstName;
        protected string _lastName;
        protected byte _experience;
        protected List<string> _responsibilities;
        protected List<string> _technologies;
        protected string _gitAccount;
        protected string _company;

        public Engineer()
        {
            _identifier = Guid.Empty;
            _firstName = "unknown";
            _lastName = "unknown";
            _experience = 0;
            _responsibilities = new List<string>();
            _technologies = new List<string>();
            _gitAccount = "unknown";
            _company = "unknown";
        }

        public Guid Identifier { get => _identifier; private set => _identifier = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public byte Experience { get => _experience; set => _experience = value; }
        public List<string> Responsibilities { get => _responsibilities; set => _responsibilities = value; }
        public List<string> Technologies { get => _technologies; set => _technologies = value; }
        public string GitAccount { get => _gitAccount; set => _gitAccount = value; }
        public virtual string Company { get => _company; set => _company = value; }

        public virtual short GetSalary()
        {
            return _baseSalary;
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

        public virtual void ShowInformation() { }
    }
}

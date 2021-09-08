using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Models
{
    class Student
    {
        public string FirstName;
        public string LastName;

        public Student()
        {
            FirstName = Faker.Name.First();
            LastName = Faker.Name.Last();
        }
        public override string ToString()
        {
            return ($"{FirstName} {LastName}");
        }
    }
}

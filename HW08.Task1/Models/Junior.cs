﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW08.Task1.Models
{
    class Junior : Engineer
    {
        private static string _title = "Junior Developer";

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

        public override void ShowInformation()
        {
            Console.WriteLine($"Company: {_company}, Full Name: {_firstName} {_lastName}, Experience: {_experience}, Title: {_title}");
            Console.WriteLine($"Salary: {GetSalary()}, GitHub: {_gitAccount}");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW08.Task1.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> junResp = new List<string>() { "English", "SQL Server", "Algorithms", "Coding", "Testing" };
            List<string> midResp = new List<string>() { "English", "APIcreating", "TriggerCreating", "Communication with customers", "Modul testing" };
            List<string> senResp = new List<string>() { "English", "software development", "Requirements analysis", "Communication with customers", "Comply with standards" };
            List<string> teamResp = new List<string>() { "English", "Mentoring", "Requirements analysis", "Setting goals and measuring progress", "Conflict resolution" };
            List<string> architectResp = new List<string>() { "English", "Вefining an architectural pattern", "selection of means of execution", "definition of data storage and transmission formats", "selection of technical means and templates for the implementation of subsystems" };

            List<string> junTech = new List<string>() { "C#", "Entity Framework", "SQL" };
            List<string> midTech = new List<string>() { "good C#", "Entity Framework", "SQL", "Angular", ".Net Core" };
            List<string> senTech = new List<string>() { "OOP", "SOLID", "MS SQL", "Git", "Docker/Azure" };
            List<string> teamTech = new List<string>() { "C# 5year", "NET Core", "RabbitMQ", "MongoDB", "ability to predict" };
            List<string> architectTech = new List<string>() { "TCP/IP stack", "C# expert level", "Experience in developing the architecture of complex / high-load applications" };

            List<Engineer> list = new List<Engineer>();
            Random randomizer = new Random();
            int employeesNumber = 30;
            string company, firstName, lastName, gitHub;
            for (int i = 0; i < employeesNumber; i++)
            {
                company = Faker.Company.Name();
                firstName = Faker.Name.First();
                lastName = Faker.Name.Last();
                gitHub = "https://github.com/" + Faker.Internet.UserName();
                switch (randomizer.Next(1, 6))
                {
                    case 1:
                        Junior jun = new Junior(firstName,
                                                lastName,
                                                (byte)randomizer.Next(0, 2),
                                                junResp,
                                                junTech,
                                                gitHub,
                                                company);
                        list.Add(jun);
                        break;
                    case 2:
                        Middle mid = new Middle(firstName,
                                                lastName,
                                                (byte)randomizer.Next(2, 4),
                                                midResp,
                                                midTech,
                                                gitHub,
                                                company);
                        list.Add(mid);
                        break;
                    case 3:
                        Senior sen = new Senior(firstName,
                                                lastName,
                                                (byte)randomizer.Next(4, 8),
                                                senResp,
                                                senTech,
                                                gitHub,
                                                company);
                        list.Add(sen);
                        break;
                    case 4:
                        TeamLeader teamL = new TeamLeader(firstName,
                                                lastName,
                                                (byte)randomizer.Next(5, 10),
                                                teamResp,
                                                teamTech,
                                                gitHub,
                                                company);
                        list.Add(teamL);
                        break;
                    case 5:
                        Architect arch = new Architect(firstName,
                                                lastName,
                                                (byte)randomizer.Next(5, 20),
                                                architectResp,
                                                architectTech,
                                                gitHub,
                                                company);
                        list.Add(arch);
                        break;
                }

            }
            var sorted = from o in list orderby o.Experience select o;

            foreach (Engineer eng in sorted)
            {
                eng.ShowInformation();
                Console.WriteLine(eng.GetResponsibilities());
                Console.WriteLine();
            }
        }
    }
}

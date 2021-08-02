using System;

namespace HW07.Task1
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Stiv Macconelly";
            person.SetAge(50);
            person.Greet();

            Student student = new Student();
            student.Name = "Khodzin Ilya";
            student.SetAge(21);
            student.Greet();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Vadim Papko";
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}

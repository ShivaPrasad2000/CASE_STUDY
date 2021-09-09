using System;

namespace Student
{
    interface IStudent
    {
        string LibCardNumber { get; set; }
        int Year { get; set; }
        void Register();
        void PostCourseWork(string work);
    }
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public Employee()
        {
            employeeId = 12345;
            employeeName = "david";
        }
        public Employee(int id, string name)
        {
            employeeId = id;
            employeeName = name;
        }

    }
    class PartTimeStudent : Employee, IStudent
    {
        public string libCardNumber = "548451";
        public int year = 2;
        public string LibCardNumber{ get;set; }
        public int Year{ get;set; }

        public void PostCourseWork(string work)
        {
            Console.WriteLine($"{work}");
        }

        public void Register()
        {
            Console.WriteLine($"{employeeName} is Registered");
        }
    }

    class AddEmployee
    {
        static void Main(string[] args)
        {
            PartTimeStudent emp1 = new PartTimeStudent();
            emp1.Register();
            emp1.PostCourseWork("");
        }
    }
}

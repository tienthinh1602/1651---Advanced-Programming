using System;

namespace Homework
{
    class ex02test{
        public static void Main(String[] args)
        {
            Employee Thinh = new Employee(200796, "Nguyen Tien", "Thinh", 1000);
            Console.WriteLine("\nFullname: " + Thinh.Fullname());
            Console.WriteLine("Salary: " + Thinh.salary);
            Console.WriteLine("Annual Salary: " + Thinh.AnnualSalary());
            Thinh.RaiseSalary(5);
            Thinh.RaiseSalary(5);
            Console.WriteLine("\nSalary after raised: " + Thinh.salary);
            Console.WriteLine();            
            Console.WriteLine(Thinh);
            Console.WriteLine();
        }
    }
}
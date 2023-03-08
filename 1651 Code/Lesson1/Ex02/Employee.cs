using System;
namespace Homework
{ 
    class Employee 
    {
        public int id{ get; private set; }
        public string firstName{ get; private set; }
        public string lastName{ get; private set; }
        public int  salary{ get; set; }

        public Employee (int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public string Fullname()
        {
            string fullname = firstName + " " + lastName;
            return fullname;  
        }

        public int AnnualSalary()
        {
            int annualSalary = salary*12;
            return annualSalary;
        }

        public int RaiseSalary(int percent)
        {
            salary += salary*percent/100;
            return salary;
        }

        public override string ToString()
        {
            return "Employee: "
                    + "ID: " + this.id + ", "
                    + "Fullname: " + this.Fullname() + ", "                    
                    + "Salary: " + this.salary;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class Employee : Person
    {
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Employee(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate)
          : base(firstName, lastName, dateOfBirth, passport)
        {
            Salary = salary;
            HireDate = hireDate;
        }
        public decimal GetAnnualSalary()
        {
            return 12 * Salary;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Salary + " " + HireDate;
        }
    }


    sealed class Engineer : Employee
    {
        public Engineer(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate)
            : base(firstName, lastName, dateOfBirth, passport, salary, hireDate) { }
        public override string GetEmploymentStatus()
        {
            return "Engineer";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    sealed class Manager : Employee
    {
        public string Department { get; set; }
        public Manager(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate, string department)
            : base(firstName, lastName, dateOfBirth, passport, salary, hireDate)
        {
            Department = department;
        }
        public override string GetEmploymentStatus()
        {
            return "Manager";
        }
        public override string ToString()
        {
            return base.ToString() + " " + Department;
        }
    }

    sealed class Secretary : Employee
    {
        public Secretary(string firstName, string lastName, DateTime dateOfBirth, string passport, decimal salary, DateTime hireDate)
            : base(firstName, lastName, dateOfBirth, passport, salary, hireDate) { }
        public override string GetEmploymentStatus()
        {
            return "Secretary";
        }
    }
}

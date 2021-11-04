using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public void IncreaseSalary(double percentage)
        {
            double increase = (Salary * percentage) / 100;
            Salary += increase;
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Id -> " + Id +
                "\nName -> " + Name +
                "\nSalary -> " + Salary;
        }
    }
}

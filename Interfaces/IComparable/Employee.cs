using System;

namespace TestProj
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string info)
        {
            string[] temp = info.Split(',');
            Name = temp[0];
            Salary = double.Parse(temp[1]);
        }

        public override string ToString()
        {
            return "Name: " + Name
                + "; Salary: " + Salary;
        }

        public int CompareTo(object? obj)
        {
            Employee temp = obj as Employee;
            return Name.CompareTo(temp.Name);
            //return Salary.CompareTo(temp.Salary);
        }
    }
}

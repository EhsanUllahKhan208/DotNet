namespace Inheritance
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public abstract double CalculateSalary();  // Abstract method for derived classes to implement

        public virtual void PrintInfo()  // Virtual method for potential override
        {
            Console.WriteLine("Name: {0}, ID: {1}", Name, ID);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }

        public override double CalculateSalary()
        {
            return Salary;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();  // Call base class PrintInfo()
            Console.WriteLine("Salary: {0}", Salary);
        }
    }

    public class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();  // Call base class PrintInfo()
            Console.WriteLine("Hourly Rate: {0}, Hours Worked: {1}", HourlyRate, HoursWorked);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Can't create objects from abstract class
            // Employee employee = new Employee();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.Name = "John Doe";
            fullTimeEmployee.ID = 123;
            fullTimeEmployee.Salary = 50000;

            HourlyEmployee hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.Name = "Jane Smith";
            hourlyEmployee.ID = 456;
            hourlyEmployee.HourlyRate = 25;
            hourlyEmployee.HoursWorked = 40;

            List<Employee> employees = new List<Employee>();
            employees.Add(fullTimeEmployee);
            employees.Add(hourlyEmployee);

            foreach (Employee employee in employees)
            {
                employee.PrintInfo();
                Console.WriteLine("Salary: {0}", employee.CalculateSalary());
            }
        }
    }

}

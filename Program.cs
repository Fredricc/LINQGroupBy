using System;

namespace LINQGroupBy
{
    public record Employee(string FirstName, string LastName, string Department);
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee("Nicholas", "Mamau", "Development"),
                new Employee("Ken", "Njuguna", "Sales"),
                new Employee("Ken", "Njenga", "Sales"),
                new Employee("Paul", "Kiprotech", "Project Management"),
                new Employee("Isaac", "Soita","Project Management"),
                new Employee("James", "Kimani", "Development")
            };

            var personsByDepartment = employees.GroupBy(person => person.Department);

            foreach (var department in personsByDepartment) 
            {
                Console.WriteLine($"Department: {department.Key}");

                foreach (var employee in department) 
                {
                    Console.WriteLine($"    {employee.FirstName} {employee.LastName}");
                }

            }
            
        }
    }
}
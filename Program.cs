using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
//Caroline Uthawong-Burr, .NET23
namespace OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)

            //DEL 1 - STACK
        {
            Employee employee1 = new Employee(101, "Michael Scott", "Male", 60000);
            Employee employee2 = new Employee(102, "Dwight Schrute", "Male", 40000);
            Employee employee3 = new Employee(103, "Jim Halpert", "Male", 50000);
            Employee employee4 = new Employee(104, "Pam Beesly", "Female", 50000);
            Employee employee5 = new Employee(105, "Kelly Kapoor", "Female", 35000);

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (var employees in employeeStack)
            {
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
                Console.WriteLine($"{employees.Id} - {employees.Name} - {employees.Gender} - {employees.Salary}");
            }
            Console.WriteLine("\n------------------------------------------\n");

            while (employeeStack.Count > 0)
            {
                var employee = employeeStack.Pop();
                Console.WriteLine($"Retrieve using Pop method:");
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
            }
            Console.WriteLine("\n------------------------------------------\n");

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            int whileCounter = 0;

            Console.WriteLine($"Retrieve using Peek method:");
            while (whileCounter < 2)
            {
                var employee = employeeStack.Peek();
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
                whileCounter++;
            }
            Console.WriteLine("\n------------------------------------------\n");

            var employeeArray = employeeStack.ToArray();
            if (employeeStack.Contains(employeeArray[2]))
            {
                Console.WriteLine($"Employee ID {employeeArray[2].Id} is in stack.");
            }
            Console.WriteLine("\n------------------------------------------\n");

            //DEL 2 - LIST

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
            
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object object does not exist in the list.");
            }
            Console.WriteLine("\n------------------------------------------\n");

            Console.WriteLine("First MALE object in the list:");
            var employeeGender = employeeList.Find(x => x.Gender == "Male");
            Console.WriteLine($"{employeeGender.Id} - {employeeGender.Name} - {employeeGender.Gender} - {employeeGender.Salary}");

            Console.WriteLine("\n------------------------------------------\n");

            Console.WriteLine("All MALES in the list:");
            var employeeGenderAll = employeeList.FindAll(x => x.Gender == "Male");
            foreach (var item in employeeGenderAll)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Gender} - {item.Salary}");
            }
            Console.WriteLine("\n------------------------------------------\n");
        }
    }
}
using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public  class EmployeeService
    {
        //Employee Services
        static EmployeeRepository employeeDb = new(FluentNHibernateHelper.OpenSession());

        //Add new Employee
        public static void AddEmployee(Employee employee)
        {
            employeeDb.Add(employee);
            Console.WriteLine("Added new Employee");
        }

        //Get Employee by Id
        public static void GetEmployeeById(int id)
        {
            Employee employee = employeeDb.GetById(id);
            if (employee == null)
            {
                Console.WriteLine($"Employee id: {id} not found");
            }
            else
            {
                Console.WriteLine($"Employee id: {employee.Id}, Address: {employee.Address}");
            }
           
        }

        //Update Employee
        public static void UpdateEmployee(Employee employee)
        {
            employeeDb.Update(employee);
            Console.WriteLine("Updated successfully");
        }

        //Delete Employee
        public static void DeleteEmployee(int id)
        {
            Employee employee = employeeDb.GetById(id);
            if (employee == null)
            {
                Console.WriteLine($"Employee id: {id} not found");
            }
            else
            {
                employeeDb.Remove(employee);
                Console.WriteLine("Deleted successfully");
            }
        }

    }
}

using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public class CustomerService
    {
        //Customer services
        static CustomerRepository customerDb = new(FluentNHibernateHelper.OpenSession());

        //Add new customer
        public static void AddCustomer(Customer customer)
        {
            customerDb.Add(customer);
            Console.WriteLine("Added new Customer");
        }

        //Get customer by id
        public static void GetCustomerById(int id)
        {
            Customer customer = customerDb.GetById(id);
            if (customer == null)
            {
                Console.WriteLine($"Customer id: {id} not found");
            }
            else
            {
                Console.WriteLine($"Customer id: {customer.Id} has address {customer.Address}");
            }
        }

        //Update customer
        public static void UpdateCustomer(Customer customer)
        {
            customerDb.Update(customer);
            Console.WriteLine("Updated successfully");
        }

        //Delete customer
        public static void DeleteCustomer(int id)
        {
            Customer customer = customerDb.GetById(id);
            if (customer == null)
            {
                Console.WriteLine($"Customer id: {id} not found");
            }
            else
            {
                customerDb.Remove(customer);
                Console.WriteLine("Deleted successfully");

            }

        }
    }
}

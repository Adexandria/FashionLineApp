using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public class OrderService
    {
        //Order Services
        static OrderRepository orderDb = new(FluentNHibernateHelper.OpenSession());

        //Add new Order
        public static void AddOrder(Order order)
        {

            orderDb.Add(order);
            Console.WriteLine("Added new Order");
        }

        //Get order by Id
        public static void GetOrderById(int id)
        {
            Order order = orderDb.GetById(id);
            if (order == null)
            {
                Console.WriteLine($"Order id: {id} not found");
            }
            else
            {
                Console.WriteLine($"Order id: {order.Id}, InitiationDate: {order.InitiationDate}, Delivery Date: {order.DeliveryDate}");
            }
           
        }

        //Update Order
        public static void UpdateOrder(Order order)
        {
            orderDb.Update(order);
            Console.WriteLine("Updated successfully");
        }

        //Delete Order
        public static void DeleteOrder(int id)
        {
            Order order = orderDb.GetById(id);
            if (order == null)
            {
                Console.WriteLine($"Order id: {id} not found");
            }
            else
            {
                orderDb.Remove(order);
                Console.WriteLine("Deleted successfully");
            }
        }
    }
}

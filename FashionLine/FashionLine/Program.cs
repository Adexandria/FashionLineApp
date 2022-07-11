using FashionLine.DB.Services;
using FashionLine.Domain;

namespace FashionLine
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            //New Measurement Object
            Measurement measurement = new()
            {
                Hip = 29.3f,
                Neck = 12.5f,
                Shoulder = 15.7f,
                Waist = 20.5f
            };

            //Updated measurement
            Measurement updatedMeasurement = new()
            {
                Id = 1,
                Hip = 30.3f,
                Neck = 12.5f,
                Shoulder = 15.7f,
                Waist = 20.5f
            };

            //Crud operations for Measurement

            //MeasurementService.AddMeasurement(measurement);
            //MeasurementService.GetMeasurementById(2);
            //MeasurementService.UpdateMeasurement(updatedMeasurement);
            //MeasurementService.DeleteMeasurement(1);


            //New FashionLine Object
            Domain.FashionLine fashionLine = new()
            {
                Location = "hsjs",
                Name = "haua"
            };

            //Updated fashionLine object
            Domain.FashionLine updatedFashionLine = new()
            {
                Id = 1,
                Location = "hsjs",
                Name = "haus"
            };

            //Crud operations for FashionLine

            //FashionLineService.AddFashionLine(fashionLine);
            //FashionLineService.GetFashionLineById(2);
            //FashionLineService.UpdateFashionLine(updatedFashionLine);
            //FashionLineService.DeleteFashionLine(1);


            //New Customer Object
            Customer customer = new()
            {
                Address = "hshjs",
                FashionLine = updatedFashionLine

            };

            //Updated Customer Object
            Customer updatedCustomer = new()
            {
                Id = 1,
                Address = "hshja",
                FashionLine = updatedFashionLine
            };

            //Crud Operations for Customer

            //CustomerService.AddCustomer(customer);
            //CustomerService.GetCustomerById(5);
            //CustomerService.UpdateCustomer(updatedCustomer);
            //CustomerService.DeleteCustomer(1);



            //new Payment Information Object

            PaymentInformation payment = new()
            {
                AmountPaid = 1000,
                Price = 1000
            };

            //Updated Payment Information object
            PaymentInformation updatedPayment = new()
            {
                Id = 1,
                AmountPaid = 1000,
                Price = 2000
            };

            //Crud Operations for payment
            
            //PaymentInfoService.AddPayment(payment);
            //PaymentInfoService.GetPaymentById(1);
            //PaymentInfoService.UpdatePayment(updatedPayment);
            //PaymentInfoService.DeletePayment(1);




            //New Order Object
            Order order = new()
            {
                Owner = updatedCustomer,
                PaymentInfo = updatedPayment,
                DeliveryAddress = updatedCustomer.Address,
                DeliveryDate = DateTime.Now.AddDays(20),
                InitiationDate = DateTime.Now
            };

            //Updated Order Object
            Order updatedOrder = new()
            {
                Id= 1,
                Owner = updatedCustomer,
                PaymentInfo = updatedPayment,
                DeliveryAddress = updatedCustomer.Address,
                DeliveryDate = DateTime.Now.AddDays(20),
                InitiationDate = DateTime.Now
            };

            //Crud operations for order

            //OrderService.AddOrder(order);
            //OrderService.GetOrderById(6);
            //OrderService.UpdateOrder(updatedOrder);
            //OrderService.DeleteOrder(1);



            //New Clothe Object

            Clothe clothe = new()
            {
                FashionLine = updatedFashionLine,
                ClotheType = ClotheType.Trouser,
                Order = updatedOrder,
                Measurement = updatedMeasurement
            };

            //Updated Clothe Object
            Clothe updatedClothe = new()
            {
                Id= 1,
                FashionLine = updatedFashionLine,
                ClotheType = ClotheType.Gown,
                Order = updatedOrder,
                Measurement = updatedMeasurement
            };

            //Crud operations for clothe

            //ClotheService.AddClothe(clothe);
            //ClotheService.GetClotheById(4);
            //ClotheService.UpdateClothe(updatedClothe);
            //ClotheService.DeleteClothe(1);



            //New Employee Object
            Employee employee = new()
            {
                FirstName = "hshjs",
                LastName = "hshjs",
                Address = "hshjs",
                EmployeeRole = Role.Attendant,
                FashionLine = updatedFashionLine
            };

            //Updated Employee Object
            Employee updatedEmployee = new()
            {
                Id = 1,
                FirstName = "hshjs",
                LastName = "hshjs",
                Address = "hshjs",
                EmployeeRole = Role.Manager,
                FashionLine = updatedFashionLine
            };

            //Crud Operations

            //EmployeeService.AddEmployee(employee);
            //EmployeeService.GetEmployeeById(2);
            //EmployeeService.UpdateEmployee(updatedEmployee);
            //EmployeeService.DeleteEmployee(1);
        }

    }


}

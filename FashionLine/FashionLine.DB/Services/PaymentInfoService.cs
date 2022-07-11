using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public class PaymentInfoService
    {
        //Payment Services
        static PaymentInformationRepository paymentDb = new(FluentNHibernateHelper.OpenSession());

        

        //Add new Payment Information
        public static void AddPayment(PaymentInformation payment)
        {
            paymentDb.Add(payment);
            Console.WriteLine("Added new Payment");
        }

        //Get payment by Id
        public static void GetPaymentById(int id)
        {
            PaymentInformation payment = paymentDb.GetById(id);
            if (payment == null)
            {
                Console.WriteLine($"Payment id: {id} not found");
            }
            else
            {
                Console.WriteLine($"Payment id: {payment.Id}, Price: {payment.Price}, Balance: {payment.Balance}");
            }
            
        }

        //Update Payment
        public static void UpdatePayment(PaymentInformation payment)
        {
            paymentDb.Update(payment);
            Console.WriteLine("Updated successfully");
        }

        //Delete Payment
        public static void DeletePayment(int id)
        {
            PaymentInformation payment = paymentDb.GetById(id);
            if (payment == null)
            {
                Console.WriteLine($"Payment id: {id} not found");
            }
            else
            {
                paymentDb.Remove(payment);
                Console.WriteLine("Deleted successfully");
            }
        }
    }
}

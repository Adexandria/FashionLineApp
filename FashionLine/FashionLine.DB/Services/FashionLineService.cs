using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public class FashionLineService
    {
        //Fashion services
        static FashionLineRepository fashionLineDb = new(FluentNHibernateHelper.OpenSession());

        //Add new FashionLine
        public static void AddFashionLine(Domain.FashionLine fashionLine)
        {
            fashionLineDb.Add(fashionLine);
            Console.WriteLine("Added new Fashion Line");
        }

        //Get Fashion Line by Id
        public static void GetFashionLineById(int id)
        {
            Domain.FashionLine fashionLine = fashionLineDb.GetById(id);
            if (fashionLine == null)
            {
                Console.WriteLine($"Fashion Line id {id} not found");
            }
            else
            {
                Console.WriteLine($"Fashion Line id: {fashionLine.Id}, Address: {fashionLine.Location}");
            }
            
        }

        //Update Fashion Line
        public static void UpdateFashionLine(Domain.FashionLine fashionLine)
        {
            fashionLineDb.Update(fashionLine);
            Console.WriteLine("Updated successfully");
        }

        //Delete Fashion Line
        public static void DeleteFashionLine(int id)
        {
            FashionLine.Domain.FashionLine fashionLine = fashionLineDb.GetById(id);
            if (fashionLine == null)
            {
                Console.WriteLine($"Fashion Line id {id} not found");
            }
            else
            {
                fashionLineDb.Remove(fashionLine);
                Console.WriteLine("Deleted successfully");
            }
        }
    }
}

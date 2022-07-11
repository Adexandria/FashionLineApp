using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public class ClotheService
    {
        //Clothe Services
        static ClotheRepository clotheDb = new(FluentNHibernateHelper.OpenSession());

        // Add new Clothe
        public static void AddClothe(Clothe clothe)
        {
            clotheDb.Add(clothe);
            Console.WriteLine("Added new clothe");
        }

        //Get clothe by id
        public static void GetClotheById(int id)
        {
            Clothe clothe = clotheDb.GetById(id);
            if(clothe == null)
            {
                Console.WriteLine($"Clothe id: {id} not found");
            }
            else
            {
                Console.WriteLine($"Clothe id: {id}, Clothe type : {clothe.ClotheType}");
            }
            
        }

        //Update clothe
        public static void UpdateClothe(Clothe clothe)
        {
            clotheDb.Update(clothe);
            Console.WriteLine("Updated Successfully");

        }

        //Delete clothe
        public static void DeleteClothe(int id)
        {
            Clothe clothe = clotheDb.GetById(id);
            if (clothe == null)
            {
                Console.WriteLine($"Clothe id: {id} not found");
            }
            else
            {
                clotheDb.Remove(clothe);
                Console.WriteLine("Deleted successfully");
            }

        }

    }
}

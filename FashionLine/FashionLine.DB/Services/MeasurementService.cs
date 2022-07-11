using FashionLine.DB.Repositories;
using FashionLine.Domain;

namespace FashionLine.DB.Services
{
    public class MeasurementService
    {
        //Measurement Services
        static MeasurementRepository measurementDb = new(FluentNHibernateHelper.OpenSession());

        //Add new Measurement
        public static void AddMeasurement(Measurement measurement)
        {
            measurementDb.Add(measurement);
            Console.WriteLine("Added new measurement");
        }

        //Get measurement by Id
        public static void GetMeasurementById(int id)
        {
            Measurement measurement = measurementDb.GetById(id);
            if (measurement == null)
            {
                Console.WriteLine($"Measurement id: {id} not found");
            }
            else
            {
                Console.WriteLine($"Measurement id: {measurement.Id} has neck: {measurement.Neck}, shoulder: {measurement.Shoulder}" +
               $" waist: {measurement.Waist} and hip: {measurement.Hip}");
            }

        }

        //Update Measurement 
        public static void UpdateMeasurement(Measurement measurement)
        {
            measurementDb.Update(measurement);
            Console.WriteLine("Updated Successfully");
        }

        // Delete Measurement
        public static void DeleteMeasurement(int id)
        {
            Measurement measurement = measurementDb.GetById(id);
            if (measurement == null)
            {
                Console.WriteLine($"Measurement id: {id} not found");
            }
            else
            {
                measurementDb.Remove(measurement);
                Console.WriteLine("Deleted successfully");
            }

        }

    }
}

using System.Globalization;
using Section014_Interface.Entities;
using Section014_Interface.Services;

namespace Section014_Interface; 

public class Program {
    public static void Main(string[] args) {

        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        
            const string carModel = "Civic";
            double pricePerHour = double.Parse("10.0", cultureInfo);
            double pricePerDay = double.Parse("130.0", cultureInfo);
        
            DateTime startDate = DateTime.ParseExact("25/06/2018 10:30", "dd/MM/yyyy HH:mm", cultureInfo);
            DateTime finishDate = DateTime.ParseExact("25/06/2018 14:40", "dd/MM/yyyy HH:mm", cultureInfo);

            CarRental carRental = new CarRental(startDate, finishDate, new Vehicle(carModel));
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
        
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice);
        }

        Console.WriteLine();

        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        
            const string carModel = "Civic";
            double pricePerHour = double.Parse("10.0", cultureInfo);
            double pricePerDay = double.Parse("130.0", cultureInfo);
        
            DateTime startDate = DateTime.ParseExact("25/06/2018 10:30", "dd/MM/yyyy HH:mm", cultureInfo);
            DateTime finishDate = DateTime.ParseExact("27/06/2018 11:40", "dd/MM/yyyy HH:mm", cultureInfo);

            CarRental carRental = new CarRental(startDate, finishDate, new Vehicle(carModel));
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
        
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice);
        }
    }
}
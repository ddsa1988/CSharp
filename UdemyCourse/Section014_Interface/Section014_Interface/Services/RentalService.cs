using Section014_Interface.Entities;

namespace Section014_Interface.Services; 

public class RentalService {

    private double pricePerHour;
    private double pricePerDay;
    private ITaxService taxService;

    public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
        this.taxService = taxService;
    }
    
    public double PricePerHour {
        get { return pricePerHour; }
        private set { pricePerHour = value > 0 ? value : 0; }
    }
    
    public double PricePerDay {
        get { return pricePerDay; }
        private set { pricePerDay = value > 0 ? value : 0; }
    }

    public void ProcessInvoice(CarRental carRental) {
        
        TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
        
        const int minHour = 12;
        double basicPayment = 0.0;
        double tax = 0.0;

        if (duration.TotalHours <= minHour) {
            basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
        } else {
            basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
        }

        tax = taxService.Tax(basicPayment);

        carRental.Invoice = new Invoice(basicPayment, tax);
    }
}
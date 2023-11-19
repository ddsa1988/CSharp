namespace Section014_Exercise.Services; 

public class PaypalService : IOnlinePaymentService {
    
    private double fee;
    private double monthlyInterest;
    
    public PaypalService(double fee, double monthlyInterest) {
        Fee = fee;
        MonthlyInterest = monthlyInterest;
    }

    private double Fee {
        get { return fee; }
        set { fee = (Math.Abs(value) <= 100 ? Math.Abs(value) : 100.0) / 100.0; }
    }
    
    private double MonthlyInterest {
        get { return monthlyInterest; }
        set { monthlyInterest = (Math.Abs(value) <= 100 ? Math.Abs(value) : 100.0) / 100.0; }
    }
    
    public double PaymentFee(double amount) {
        double tax = Fee * Math.Abs(amount);
        
        return Math.Abs(amount) + tax;
    }

    public double Interest(double amount, int months) {
        double tax = MonthlyInterest * Math.Abs(amount) * Math.Abs(months);
        
        return Math.Abs(amount) + tax;
    }
}
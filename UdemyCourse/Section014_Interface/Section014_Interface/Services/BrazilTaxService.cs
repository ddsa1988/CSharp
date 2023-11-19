namespace Section014_Interface.Services; 

public class BrazilTaxService : ITaxService {

    public double Tax(double amount) {

        const double minIncome = 100.0;
        const double taxRate1 = 15.0 / 100.0;
        const double taxRate2 = 20.0 / 100.0;
        
        if (amount > minIncome) {
            return amount * taxRate1;
        }

        return amount * taxRate2;
    }
}
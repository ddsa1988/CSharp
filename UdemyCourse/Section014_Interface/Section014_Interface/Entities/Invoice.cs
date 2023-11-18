using System.Globalization;

namespace Section014_Interface.Entities; 

public class Invoice {

    private double basicPayment;
    private double tax;
    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    
    public Invoice(double basicPayment, double tax) {
        BasicPayment = basicPayment;
        Tax = tax;
    }
    
    public double BasicPayment {
        get { return basicPayment; }
        set { basicPayment = value > 0 ? value : 0; }
    }

    public double Tax {
        get { return tax; }
        set { tax = value > 0 ? value : 0; }
    }

    public double TotalPayment {
        get { return BasicPayment + Tax; }
    }

    public override string ToString() {
        return "Basic payment: " + BasicPayment.ToString("F2", cultureInfo)
               + "\nTax: " + Tax.ToString("F2", cultureInfo)
               + "\nTotal payment: " + TotalPayment.ToString("F2", cultureInfo);
    }
}
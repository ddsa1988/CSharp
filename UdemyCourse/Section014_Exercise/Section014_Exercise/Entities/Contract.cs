using System.Globalization;

namespace Section014_Exercise.Entities; 

public class Contract {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private int number;
    private double totalValue;
    public DateTime Date { get; set; }

    public Contract(int number, double totalValue) {
        Number = number;
        TotalValue = totalValue;
    }
    
    public int Number {
        get { return number; }
        set { number = value > 0 ? value : 0; }
    }

    public double TotalValue {
        get { return totalValue; }
        set { totalValue = value > 0 ? value : 0; }
    }

    public override string ToString() {
        return "Number: " + Number +
               "\nDate: " + Date.ToString(cultureInfo) +
               "\nTotal value: $" + TotalValue.ToString("F2", cultureInfo);
    }
}
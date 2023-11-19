using System.Globalization;

namespace Section014_Exercise.Entities; 

public class Installment {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private double amount;
    public DateTime DueDate { get; set; }

    public Installment(DateTime dueDate, double amount) {
        DueDate = dueDate;
        Amount = amount;
    }
    
    public double Amount {
        get { return amount; }
        set { amount = value > 0 ? value : 0; }
    }

    public override string ToString() {
        return "Due date: " + DueDate.ToShortDateString() +
               "\nAmount: $" + Amount.ToString("F2", cultureInfo);
    }
}
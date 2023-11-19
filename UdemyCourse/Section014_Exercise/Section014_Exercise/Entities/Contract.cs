using System.Globalization;
using System.Text;

namespace Section014_Exercise.Entities; 

public class Contract {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private int number;
    private double totalValue;
    private List<Installment> installments = new List<Installment>();
    public DateTime Date { get; set; }
    
    public Contract(int number, DateTime date, double totalValue) {
        Number = number;
        Date = date;
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

    public void AddInstallment(Installment installment) {
        installments.Add(installment);
    }

    public void RemoveInstallmet(Installment installment) {
        installments.Remove(installment);
    }

    public override string ToString() {

        StringBuilder sb = new StringBuilder();
        sb.Append("Number: " + Number +
                  "\nDate: " + Date.ToShortDateString() +
                  "\nTotal value: $" + TotalValue.ToString("F2", cultureInfo));

        if (installments.Count > 0) {
            sb.Append("\n\nInstallments:");
            
            foreach (Installment installment in installments) {
                sb.Append("\n" + installment);
            }
        }
        
        return sb.ToString();
    }
}
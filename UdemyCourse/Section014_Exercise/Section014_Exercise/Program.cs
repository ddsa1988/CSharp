using System.Globalization;
using Section014_Exercise.Entities;
using Section014_Exercise.Services;

namespace Section014_Exercise;

public class Program {
    public static void Main(string[] args) {

        CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        DateTime date = DateTime.ParseExact("25/06/2018", "dd/MM/yyyy", cultureInfo);
        
        Contract contract = new Contract(8028, date, 600.0);
        ContractService contractService = new ContractService(new PaypalService(2, 1));
        contractService.ProcessContract(contract, 3);

        Console.WriteLine(contract);
    }
}
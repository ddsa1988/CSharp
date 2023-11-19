using Section014_Exercise.Entities;

namespace Section014_Exercise.Services; 

public class ContractService {

    private IOnlinePaymentService onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService) {
        this.onlinePaymentService = onlinePaymentService;
    }
    
    public void ProcessContract(Contract contract, int months) {

        int numberOfMonths = Math.Abs(months);
        double baseQuota = contract.TotalValue / numberOfMonths;

        for (int i = 0; i < numberOfMonths; i++) {
            DateTime nextDate = contract.Date.AddMonths(i + 1);
            double nextInterest = onlinePaymentService.Interest(baseQuota, i + 1);
            double nextQuota = onlinePaymentService.PaymentFee(nextInterest);

            Installment installment = new Installment(nextDate, nextQuota);
            
            contract.AddInstallment(installment);
        }
    }
}
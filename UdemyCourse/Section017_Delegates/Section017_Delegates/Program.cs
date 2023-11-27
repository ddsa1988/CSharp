namespace Section017_Delegates;

public class Program {
    
    public static void Main(string[] arg) {

        const int choice = 4;

        switch (choice) {
            case 1:
                Console.WriteLine("Delegates:\n");
                Example001.CallMain();
                break;
            case 2:
                Console.WriteLine("Delegate Predicate:\n");
                Example002.CallMain();
                break;
            case 3:
                Console.WriteLine("Delegate Action:\n");
                Example003.CallMain();
                break;
            case 4:
                Console.WriteLine("Delegate Func:\n");
                Example004.CallMain();
                break;
        }
    }
}
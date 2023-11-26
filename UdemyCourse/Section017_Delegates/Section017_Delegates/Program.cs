using Section017_Delegates.Services;

namespace Section017_Delegates;

public class Program {
    
    public static void Main(string[] arg) {

        const int choice = 2;

        switch (choice) {
            case 1:
                Console.WriteLine("Delegates:\n");
                Exemple001.CallMain();
                break;
            case 2:
                Console.WriteLine("Delegate predicate:\n");
                Exemple002.CallMain();
                break;
            default:
                break;
        }
    }
}
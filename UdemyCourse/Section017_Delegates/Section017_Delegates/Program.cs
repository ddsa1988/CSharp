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
                Console.WriteLine("Delegate Predicate:\n");
                Exemple002.CallMain();
                break;
            case 3:
                Console.WriteLine("Delegate Action:\n");
                Exemple003.CallMain();
                break;
            case 4:
                Console.WriteLine("Delegate Func:\n");
                Exemple004.CallMain();
                break;
        }
    }
}
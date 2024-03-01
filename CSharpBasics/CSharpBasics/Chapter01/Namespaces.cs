namespace CSharpBasics.Chapter01;

using static System.Console; //Import all statics members
using Print = System.Console; //Alias names

public class Namespaces {
    public static void MyMain() {
        Write("Test 1");
        WriteLine("\nTest 2");
        
        Print.WriteLine("Test 3");
    }
}
using System.Text;

namespace CSharpBasics.Chapter01;

public class VariablesAndParameters {
    public static void MyMain() {
        Console.WriteLine(Sum(2,5)); // 2 and 5 are arguments
        Console.WriteLine();
        
        // Passing arguments by value
        {
            // Passing a value type by value copies the variable value
            
            const int x = 2;
            SumX(x);
            Console.WriteLine(x);
            
            // Passing a reference type by value copies the variable reference but not the object
            StringBuilder sb = new StringBuilder("Start ");
            ConcatString(sb);
            Console.WriteLine(sb.ToString());
        }

        Console.WriteLine();
        
        // Passing arguments by reference
        {
            //The 'ref' modifier
            
            int a = 20;
            int b = 30;
            
            Console.WriteLine($"a = {a} b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a} b = {b}");
        }
            
    }

    private static float Sum(float a, float b) { // a and b are parameters
        return a + b;
    }

    private static void SumX(int x) {
        x++;
        Console.WriteLine(x);
    }

    private static void ConcatString(StringBuilder sb) {
        sb.Append("Test");
        sb = null;
    }

    private static void Swap(ref int a, ref int b) {
        a = a + b;
        b = a - b;
        a = a - b;
    }
}
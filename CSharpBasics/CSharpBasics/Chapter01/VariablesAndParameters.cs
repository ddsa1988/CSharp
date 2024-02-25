using System.Text;

namespace CSharpBasics.Chapter01;

public class VariablesAndParameters {
    public static void MyMain() {
        Console.WriteLine(Sum(2, 5)); // 2 and 5 are arguments
        Console.WriteLine();

        // Passing arguments by value
        {
            // Passing a value type by value copies the variable value

            const int a = 2;
            SumX(a);
            Console.WriteLine(a);

            // Passing a reference type by value copies the variable reference but not the object
            StringBuilder sb = new StringBuilder("Start ");
            ConcatString(sb);
            Console.WriteLine(sb.ToString());
        }

        Console.WriteLine();

        // Passing arguments by reference
        {
            //The "ref" modifier

            int a = 20;
            int b = 30;
            int c = 8;

            Console.WriteLine($"a = {a} b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a} b = {b}");

            SumRef(ref c);
            Console.WriteLine(c);
        }
        Console.WriteLine();
        {
            //The "out" modifier
            const string a = "Diego dos Santos Alexandre";
            
            SplitName(a, out string b, out string c);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        Console.WriteLine();
        {
            //The "in" modifier
            
            /*An in parameter is similar to a ref parameter except that the argument’s value
            cannot be modified by the method (doing so generates a compile-time error). This
            modifier is most useful when passing a large value type to the method because it
            allows the compiler to avoid the overhead of copying the argument prior to passing
            it in while still protecting the original value from modification.*/
            
            string a = "Diego dos Santos Alexandre";
            
            SplitName(in a, out string b, out string c);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        Console.WriteLine();
        
        //The params modifier
        {
            int[] myNumbers = new int[] { 1, 2, 3, 4, 5 };
            
            Console.WriteLine(Sum("Test 1",2,3,4,5));
            Console.WriteLine(Sum("Test 2", myNumbers));
        }
    }

    private static float Sum(float x, float y) {
        // a and b are parameters
        return x + y;
    }

    private static void SumX(int x) {
        x++;
        Console.WriteLine(x);
    }

    private static void ConcatString(StringBuilder sb) {
        sb.Append("Test");
        sb = null;
    }

    private static void SumRef(ref int x) {
        x++;
    }

    private static void Swap(ref int x, ref int y) {
        x += y; // x = x + y
        y = x - y;
        x -= y; // x = x - y
    }

    private static void SplitName(string name, out string firstName, out string lastName) {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) {
            firstName = string.Empty;
            lastName = string.Empty;
        } else {
            int index = name.LastIndexOf(' ');
            firstName = name.Substring(0, index);
            lastName = name.Substring(index + 1);
        }
    }
    
    private static void SplitName(in string name, out string firstName, out string lastName) {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) {
            firstName = string.Empty;
            lastName = string.Empty;
        } else {
            int index = name.LastIndexOf(' ');
            firstName = name.Substring(0, index);
            lastName = name.Substring(index + 1);
        }
    }

    private static int Sum(string text, params int[] numbers) {
        int sum = 0;

        Console.WriteLine(text);
        
        foreach (int number in numbers) {
            sum += number;
        }

        return sum;
    }
}
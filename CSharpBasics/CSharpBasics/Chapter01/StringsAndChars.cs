namespace CSharpBasics.Chapter01;

public class StringsAndChars {
    public static void MyMain() {
        {
            const char a = 'A';

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine((byte)a);
            Console.WriteLine(Convert.ToByte(a));
        }

        {
            const string
                a = "Diego"; //String is a reference type but its equality operator follow value-types semantics
            const string b = "Diego";
            const string c = "diego";
            const string text = @"\\server\\file share\\hello world.cs"; //Verbatim
            const int number = 100;

            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
            Console.WriteLine(text);
            Console.WriteLine($"The number is {number}"); //String interpolation
            Console.WriteLine(
                $"The number is {number:F2}"); //Formatting a string. In this example the number will be with two decimal places
            Console.WriteLine($"The answer in binary is {(number > 50 ? 1 : 0)}.");
        }
    }
}
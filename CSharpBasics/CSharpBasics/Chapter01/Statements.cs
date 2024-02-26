namespace CSharpBasics.Chapter01;

public class Statements {
    public static void MyMain() {
        //Declaration statement
        {
            const string word = "rosebud";
            const int number = 42;
            const bool rich = true, famous = false;

            Console.WriteLine($"word = {word}; number = {number}, rich = {rich}, famous = {famous}");
        }

        //Local variables
        {
            int a;
            {
                //int a;
                /*You can't declare a local variable with the
                 same name in the current block or any nested blocks*/
                int b;
            }
            {
                int b;
            }
            // Console.WriteLine(b); Error: b is out of scope
        }
    }
}
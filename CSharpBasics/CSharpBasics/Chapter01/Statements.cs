using System.Text;
using System.Threading.Channels;

namespace CSharpBasics.Chapter01;

public class Statements {
    public static void MyMain() {
        //Declaration statement : A variable declaration introduces a new variable, optionally initializing it with an expression
        {
            const string word = "rosebud";
            const int number = 42;
            const bool rich = true, famous = false;

            Console.WriteLine($"word = {word}; number = {number}, rich = {rich}, famous = {famous}");
        }
        Console.WriteLine();

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

        //Expression statement: An expression statement must either change state or call something that might change state
        {
            string a;
            int x, y;
            System.Text.StringBuilder sb;

            x = 1 + 2; //Assignment expression
            x++; //Increment expression
            y = Math.Max(x, 5); //Assignment expression
            Console.WriteLine(y); //Method call expression
            sb = new StringBuilder(); //Assignment expression
            new StringBuilder(); //Object instantiation expression
        }
        Console.WriteLine();

        //If statement
        {
            const int number = 10;

            if (number < 10) {
                Console.WriteLine("Greater than 10");
            } else {
                Console.WriteLine("It's equal or greater than 10");
            }
        }
        Console.WriteLine();

        //Switch statement
        {
            const int number = 11;

            switch (number) {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case >= 10:
                    Console.WriteLine("10");
                    goto case 2;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
        Console.WriteLine();

        //Switch expression
        {
            const int number = 11;
            int answer = number switch {
                1 => 1,
                2 => 2,
                >= 10 => number,
                _ => 0 //Equivalent to default
            };
            Console.WriteLine(answer);
        }
        Console.WriteLine();

        //Break statement
        {
            for (int i = 0; i < 10; i++) {
                if (i == 5) break;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        //Continue statement
        {
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0) continue;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        //Goto statement
        {
            int a = 0;

            startLoop:
            if (a < 5) {
                Console.Write(a + " ");
                a++;
                goto startLoop;
            }
        }
        Console.WriteLine();

        //Throw statement
        {
            const int number = 10;

            try {
                if (number >= 10) {
                    throw new Exception("Exception Test");
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Finally");
            }
        }
        Console.WriteLine();

        //Return statement
        //The return statement exits the method and must return an expression of
        //the method's return type if the method is non-void
        for (int i = 0; i < 10; i++) {
            if (i == 4) return;
            Console.Write(i + " ");
        }
    }
}
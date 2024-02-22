namespace CSharpBasics.Chapter01;

public class BooleanType {
    public static void MyMain() {
        const int a = 10;
        const int b = 15;
        const int c = 10;
        const bool rain = false;
        const bool sunny = true;
        const int n1 = 0b0111_1111;
        const int n2 = 0b1101_1001;
        const int n3 = n1 & n2;
        const int n4 = n1 | n2;
        const int n5 = n1 ^ n2; //XOR
        const int n6 = 0b0110;
        const int n7 = n6 << 2; //Shift left
        const int n8 = n6 >> 1; //Shit right

        Person p1 = new Person("Diego");
        Person p2 = new Person("Diego");
        Person p3 = p1;

        Console.WriteLine(a == b);
        Console.WriteLine(a == c);
        Console.WriteLine(p1 == p2); //By default the reference type are compared by their reference
        Console.WriteLine(p1 == p3);
        Console.WriteLine(a == b ? "Equal": "Not equal" ); //Ternary operator
        Console.WriteLine(rain && sunny);
        Console.WriteLine(rain || sunny);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(Convert.ToString(n3, 2));
        Console.WriteLine(n4);
        Console.WriteLine(Convert.ToString(n4, 2));
        Console.WriteLine(n5);
        Console.WriteLine(Convert.ToString(n5, 2));
        Console.WriteLine(n6);
        Console.WriteLine(Convert.ToString(n6, 2));
        Console.WriteLine(n7);
        Console.WriteLine(Convert.ToString(n7, 2));
        Console.WriteLine(n8);
        Console.WriteLine(Convert.ToString(n8, 2));
    }

    private class Person {
        public string Name { get; set; }

        public Person(string name) {
            Name = name;
        }
    }
}
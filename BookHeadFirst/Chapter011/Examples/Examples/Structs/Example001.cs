namespace Examples.Structs;

public static class Example001 {
    public static void Run() {
        // Structs are value types

        {
            Console.WriteLine("Structs:\n");

            PersonStruct p1 = new() { Name = "P1", Age = 10, Numbers = [10, 20, 30] };
            Console.WriteLine(p1);

            PersonStruct p2 = p1;

            p2.Name = "P2";
            p2.Age = 20;
            p2.Numbers[0] = 100;
            p2.Numbers[1] = 200;
            p2.Numbers[2] = 300;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }

        Console.WriteLine();

        {
            Console.WriteLine("Classes:\n");

            PersonClass p1 = new() { Name = "P1", Age = 10, Numbers = [10, 20, 30] };
            Console.WriteLine(p1);

            PersonClass p2 = p1;

            p2.Name = "P2";
            p2.Age = 20;
            p2.Numbers[0] = 100;
            p2.Numbers[1] = 200;
            p1.Numbers[2] = 300;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }

    public struct PersonStruct {
        public required string Name { get; set; }
        public int Age { get; set; }
        public required List<int> Numbers { get; set; }

        public override string ToString() {
            return $"Name: {Name}, Age: {Age}, Numbers: [{string.Join(",", Numbers)}]";
        }
    }

    public class PersonClass {
        public required string Name { get; set; }
        public int Age { get; set; }
        public required List<int> Numbers { get; set; }

        public override string ToString() {
            return $"Name: {Name}, Age: {Age}, Numbers: [{string.Join(",", Numbers)}]";
        }
    }
}
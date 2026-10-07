namespace AnonymousTypes.Examples;

internal static class UsingAnonymousTypes {
    public static void Run() {
        BuildAnonymousTypes("BMW", "Black", 90);
    }

    private static void BuildAnonymousTypes(string make, string color, int currentSpeed) {
        var myCar1 = new { Make = make, Color = color, CurrentSpeed = currentSpeed };
        var myCar2 = new { Make = make, Color = color, CurrentSpeed = currentSpeed };

        Console.WriteLine($"You have a {myCar1.Color} {myCar1.Make} going {myCar1.CurrentSpeed} km/h.");
        Console.WriteLine($"{nameof(myCar1)}.ToString() => {myCar1.ToString()}");
        Console.WriteLine();

        ReflectOverAnonymousType(myCar1);
        ReflectOverAnonymousType(myCar2);

        EqualityTest(myCar1, myCar2);
    }

    private static void ReflectOverAnonymousType(object obj) {
        Console.WriteLine($"{nameof(obj)} is an instance of {obj.GetType().Name}");
        Console.WriteLine($"Base class of {obj.GetType().Name} is {obj.GetType().BaseType}");
        Console.WriteLine($"{nameof(obj)}.ToString() => {obj.ToString()}");
        Console.WriteLine($"{nameof(obj)}.GetHashCode() => {obj.GetHashCode()}");
        Console.WriteLine();
    }

    private static void EqualityTest(object obj1, object obj2) {
        if (obj1.Equals(obj2)) {
            Console.WriteLine("Using 'Equals' => Same anonymous object!");
        }
        else {
            Console.WriteLine("Using 'Equals' => Different anonymous object!");
        }

        if (obj1 == obj2) {
            Console.WriteLine("Using '==' => Same anonymous object!");
        }
        else {
            Console.WriteLine("Using '==' => Different anonymous object!");
        }

        if (obj1.GetType().Name == obj2.GetType().Name) {
            Console.WriteLine("Same anonymous type!");
        }
        else {
            Console.WriteLine("Different anonymous type!");
        }

        Console.WriteLine();
    }
}
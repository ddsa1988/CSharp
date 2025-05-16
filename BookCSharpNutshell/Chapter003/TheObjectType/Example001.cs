namespace Chapter003.TheObjectType;

public static class Example001 {
    public static void UserMain() {
        // The object (System.Object) is the ultimate base class for all types. Any type can be upcast to object.

        object obj1 = "Diego";
        object obj2 = 1;

        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(obj1), obj1.GetType(), obj1);
        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(obj2), obj2.GetType(), obj2);
        Console.WriteLine();

        string name = (string)obj1; // Downcast
        int number = (int)obj2; // Downcast

        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(name), name.GetType(), name);
        Console.WriteLine("{0} => Type = {1}, Value = {2}", nameof(number), number.GetType(), number);
    }
}
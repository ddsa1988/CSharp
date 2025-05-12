namespace Chapter003.Classes;

public static class Example011 {
    public static void UserMain() {
        // Partial types allow a type definition to be split—typically across multiple files.

        var user1 = new User("Diego");
        var user2 = new User("Amanda", 30);

        Console.WriteLine(user1);
        Console.WriteLine(user2);

        user2.Greeting("Hello");

        Console.WriteLine(User.Sum(20, 30));
    }
}

internal partial class User {
    public string Name { get; set; }

    public User(string name) {
        Name = name;
    }

    // Partial method definition

    public partial void Greeting(string msg);

    public static partial int Sum(int a, int b);
}

internal partial class User {
    public int Age { get; set; }

    public User(string name, int age) : this(name) {
        Age = age;
    }

    // Partial method implementation

    public partial void Greeting(string msg) {
        Console.WriteLine("Greeting: {0} {1} {2}", Name, Age, msg);
    }

    public static partial int Sum(int a, int b) {
        return a + b;
    }

    public override string ToString() {
        return $"User [ Name = {Name}, Age = {Age} ]";
    }
}
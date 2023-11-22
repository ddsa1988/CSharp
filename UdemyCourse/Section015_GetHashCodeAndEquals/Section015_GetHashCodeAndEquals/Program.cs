using Section015_GetHashCodeAndEquals.Entities;

namespace Section015_GetHashCodeAndEquals;

public class Program {
    public static void Main(string[] args) {

        Client client1 = new Client("Diego", "diego@gmail", 123);
        Client client2 = new Client("Amanda", "diego@gmail", 123);

        Console.WriteLine(client1 == client2);
        Console.WriteLine(client1.Equals(client2));
        Console.WriteLine(client1.GetHashCode());
        Console.WriteLine(client2.GetHashCode());
    }
}
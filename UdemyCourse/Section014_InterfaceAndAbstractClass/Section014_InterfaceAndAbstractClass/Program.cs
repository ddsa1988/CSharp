using Section014_InterfaceAndAbstractClass.Model.Entities;
using Section014_InterfaceAndAbstractClass.Model.Enum;

namespace Section014_InterfaceAndAbstractClass;

public class Program {
    public static void Main(string[] args) {

        IShape rectangle = new Rectangle(3, 2, Color.Black);
        IShape circle = new Circle(2, Color.Red);

        Console.WriteLine(rectangle + "\n");
        Console.WriteLine(circle);
    }
}
using Section014_InterfaceAndAbstractClass.Model.Entities;
using Section014_InterfaceAndAbstractClass.Model.Enum;

namespace Section014_InterfaceAndAbstractClass;

public class Program {
    public static void Main(string[] args) {

        IShape rectangle = new Rectangle(3, 2, Color.Black);
        IShape circle = new Circle(2, Color.Red);

        Console.WriteLine(rectangle);
        Console.WriteLine();
        Console.WriteLine(circle);
        Console.WriteLine();

        Printer p = new Printer() { SerialNumber = "1080" };
        p.ProcessDoc("My letter");
        p.Print("My letter");
        Console.WriteLine();

        Scanner s = new Scanner() { SerialNumber = "2003" };
        s.ProcessDoc("My email");
        Console.WriteLine(s.Scan());
        Console.WriteLine();

        ComboDevice c = new ComboDevice() { SerialNumber = "3921" };
        c.ProcessDoc("My doc");
        c.Print("My doc");
        Console.WriteLine(c.Scan());
    }
}
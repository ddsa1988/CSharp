using MultipleInterfaceHierarchy.Interfaces;

namespace MultipleInterfaceHierarchy.Models;

internal class Square : IShape {
    public int GetNumberOfSides() {
        return 4;
    }

    public void Print() {
        Console.WriteLine("Printing...");
    }

    void IPrintable.Draw() {
        Console.WriteLine("Drawing from IPrintable...");
    }


    void IDrawable.Draw() {
        Console.WriteLine("Drawing from IDrawable...");
    }
}
using MultipleInterfaceHierarchy.Interfaces;
using MultipleInterfaceHierarchy.Models;

namespace MultipleInterfaceHierarchy.Examples;

internal static class UsingSquareClass {
    internal static void Run() {
        var square = new Square();

        square.Print();

        ((IPrintable)square).Draw();

        ((IDrawable)square).Draw();
    }
}
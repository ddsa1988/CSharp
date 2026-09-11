using InterfaceNameClash.Interfaces;
using InterfaceNameClash.Models;

namespace InterfaceNameClash.Examples;

internal static class ExplicitInterfaceImplementation {
    internal static void Run() {
        var oct = new Octagon();

        IDrawToForm? dtf = oct;
        IDrawToMemory? dtm = oct;
        IDrawToPrinter? dtp = oct;

        dtf?.Draw();
        dtm?.Draw();
        dtp?.Draw();
    }
}
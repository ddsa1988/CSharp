using InterfaceHierarchy.Interfaces;
using InterfaceHierarchy.Models;

namespace InterfaceHierarchy.Examples;

internal static class SimpleInterfaceHierarchy {
    internal static void Run() {
        var bitmapImage = new BitmapIMage();

        bitmapImage.Draw();
        bitmapImage.DrawBoundingBox(10, 10, 100, 150);
        bitmapImage.DrawUpsideDown();

        if (bitmapImage is IAdvanceDraw iAdvanceDraw) {
            Console.WriteLine(iAdvanceDraw.TimeToDraw());
        }

        if (bitmapImage is IDrawable iDrawable) {
            Console.WriteLine(iDrawable.TimeToDraw());
        }
    }
}
using InterfaceHierarchy.Interfaces;

namespace InterfaceHierarchy.Models;

internal class BitmapIMage : IAdvanceDraw {
    public void Draw() {
        Console.WriteLine("Drawing...");
    }

    public void DrawBoundingBox(int top, int left, int bottom, int right) {
        Console.WriteLine("Drawing in a box...");
    }

    public void DrawUpsideDown() {
        Console.WriteLine("Drawing upside down!");
    }
}
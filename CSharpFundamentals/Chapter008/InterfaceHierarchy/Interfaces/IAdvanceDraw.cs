namespace InterfaceHierarchy.Interfaces;

internal interface IAdvanceDraw : IDrawable {
    internal void DrawBoundingBox(int top, int left, int bottom, int right);
    internal void DrawUpsideDown();
}
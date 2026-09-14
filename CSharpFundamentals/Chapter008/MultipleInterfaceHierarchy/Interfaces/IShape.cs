namespace MultipleInterfaceHierarchy.Interfaces;

internal interface IShape : IDrawable, IPrintable {
    public int GetNumberOfSides();
}
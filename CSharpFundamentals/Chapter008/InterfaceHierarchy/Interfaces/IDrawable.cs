namespace InterfaceHierarchy.Interfaces;

internal interface IDrawable {
    public void Draw();

    public int TimeToDraw() {
        return 5;
    }
}
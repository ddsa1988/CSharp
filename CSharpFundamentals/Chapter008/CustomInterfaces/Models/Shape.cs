namespace CustomInterfaces.Models;

internal abstract class Shape {
    public string Name { get; set; }
    public abstract void Draw();

    protected Shape(string name) {
        Name = name;
    }
}
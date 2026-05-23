namespace WorkingWithArrays.Models;

public class Person {
    public string Name { get; set; } = string.Empty;

    public override string ToString() {
        return "{ Name: " + Name + " }";
    }
}
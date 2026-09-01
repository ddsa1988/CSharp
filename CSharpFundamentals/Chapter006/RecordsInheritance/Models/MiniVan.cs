namespace RecordsInheritance.Models;

internal sealed record class Minivan : Car {
    public int Seating { get; set; }

    public Minivan(string make, string model, string color, int seating) : base(make, model, color) {
        Seating = seating;
    }
}
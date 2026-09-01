namespace RecordsInheritance.Models;

internal sealed record class MiniVanRecord : CarRecord {
    public int Seating { get; set; }

    public MiniVanRecord(string make, string model, string color, int seating) : base(make, model, color) {
        Seating = seating;
    }
}
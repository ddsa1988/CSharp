namespace RecordsInheritance.Models;

internal record class PositionalMiniVanRecord(string Make, string Model, string Color, int Seating)
    : PositionalCarRecord(Make, Model, Color);
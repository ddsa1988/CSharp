namespace LanguageIntegratedQuery.Models;

internal class Car {
    public string PetName { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public int Speed { get; set; }

    public override string ToString() {
        return
            $"Car [{nameof(PetName)} = {PetName}, {nameof(Color)} = {Color}, {nameof(Make)} = {Make}, {nameof(Speed)} = {Speed}]";
    }
}
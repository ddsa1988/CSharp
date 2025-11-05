namespace HideAndSeek.Models;

public class SavedGame {
    public required string PlayerLocation { get; set; }
    public required Dictionary<string, string> OpponentsLocations { get; set; }
    public required List<string> OpponentsFound { get; set; }
    public int MoveNumber { get; set; }
}
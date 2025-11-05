namespace HideAndSeek.Models;

public record SavedGame(
    string PlayerLocation,
    Dictionary<string, string> OpponentsLocations,
    List<string> OpponentsFound,
    int MoveNumber
);
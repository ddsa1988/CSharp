using HideAndSeek.Enums;

namespace HideAndSeek.Models;

public class Location {
    /// <summary>
    /// The name of this location
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The exits out of this location
    /// </summary>
    public readonly IDictionary<Direction, Location> Exits = new Dictionary<Direction, Location>();

    /// <summary>
    /// The constructor sets the location name
    /// </summary>
    /// <param name="name">Name of the location</param>
    public Location(string name) {
        Name = name;
    }

    public override string ToString() => Name;

    /// <summary>
    /// Describes a direction (e.g. "in" vs. "to the North")
    /// </summary>
    /// <param name="direction">Direction to describe</param>
    /// <returns>string describing the direction</returns>
    private static string DescribeDirection(Direction direction) => direction switch {
        Direction.Up => "Up",
        Direction.Down => "Down",
        Direction.In => "In",
        Direction.Out => "Out",
        _ => $"to the {direction}",
    };

    /// <summary>
    /// Returns a sequence of descriptions of the exits, sorted by direction
    /// </summary>
    public IEnumerable<string> ExitList =>
        Exits
            .OrderBy((pair) => (int)pair.Key)
            .ThenBy(pair => Math.Abs((int)pair.Key))
            .Select(pair => $" - the {Exits[pair.Key]} is {DescribeDirection(pair.Key)}");

    /// <summary>
    /// Adds an exit to this location
    /// </summary>
    /// <param name="direction">Direction of the connecting location</param>
    /// <param name="connectingLocation">Connecting location to add</param>
    public void AddExit(Direction direction, Location connectingLocation) {
        Exits.Add(direction, connectingLocation);
        connectingLocation.AddReturnExit(direction, this);
    }

    /// <summary>
    /// Adds a return exit to a connecting location
    /// </summary>
    /// <param name="direction">Direction of the connecting location</param>
    /// <param name="connectingLocation">Location to add the return exit to</param>
    private void AddReturnExit(Direction direction, Location connectingLocation) {
        int returnDirectionValue = (int)direction * -1;
        var returnDirection = (Direction)returnDirectionValue;

        Exits.Add(returnDirection, connectingLocation);
    }

    /// <summary>
    /// Gets the exit location in a direction
    /// </summary>
    /// <param name="direction">Direction of the exit location</param>
    /// <returns>The exit location, or this if there is no exit in that direction</returns>
    public Location GetExit(Direction direction) {
        return Exits.TryGetValue(direction, out Location? location) ? location : this;
    }
}
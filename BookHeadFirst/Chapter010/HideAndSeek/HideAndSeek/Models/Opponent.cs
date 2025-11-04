namespace HideAndSeek.Models;

public class Opponent {
    public string Name { get; }

    public Opponent(string name) {
        Name = name;
    }

    public Location Hide() {
        int locationsToMoveThrough = House.Random.Next(10, 20);
        Location currentLocation = House.Entry;

        for (int i = 0; i < locationsToMoveThrough; i++) {
            currentLocation = House.RandomExit(currentLocation);
        }

        while (currentLocation is not LocationWithHidingPlace) {
            currentLocation = House.RandomExit(currentLocation);
        }

        if (currentLocation is not LocationWithHidingPlace hidingPlace) return currentLocation;

        hidingPlace.Hide(this);

        System.Diagnostics.Debug.WriteLine(
            $"{Name} is hiding {hidingPlace.HidingPlace} in the {currentLocation.Name}");

        return hidingPlace;
    }

    public override string ToString() => Name;
}
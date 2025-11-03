using HideAndSeek.Enums;
using HideAndSeek.Services;

namespace HideAndSeek.Models;

public static class House {
    public static readonly Location Entry;
    public static readonly List<Location> Locations;
    public static Random Random;

    static House() {
        Entry = new Location(HouseRooms.Entry);
        Locations = [];
        Random = new Random();
        CreateLayout();
    }

    private static void CreateLayout() {
        var garage = new LocationWithHidingPlace(HouseRooms.Garage, HidingPlaces.Garage);
        var hallway = new Location(HouseRooms.Hallway);
        var kitchen = new LocationWithHidingPlace(HouseRooms.Kitchen, HidingPlaces.Kitchen);
        var bathroom = new LocationWithHidingPlace(HouseRooms.Bathroom, HidingPlaces.Bathroom);
        var livingRoom = new LocationWithHidingPlace(HouseRooms.LivingRoom, HidingPlaces.LivingRoom);
        var landing = new Location(HouseRooms.Landing);
        var masterBedroom = new LocationWithHidingPlace(HouseRooms.MasterBedroom, HidingPlaces.MasterBedroom);
        var masterBathroom = new LocationWithHidingPlace(HouseRooms.MasterBathroom, HidingPlaces.MasterBathroom);
        var secondBathroom = new LocationWithHidingPlace(HouseRooms.SecondBathroom, HidingPlaces.SecondBathroom);
        var nursery = new LocationWithHidingPlace(HouseRooms.Nursery, HidingPlaces.Nursery);
        var pantry = new LocationWithHidingPlace(HouseRooms.Pantry, HidingPlaces.Pantry);
        var kidsRoom = new LocationWithHidingPlace(HouseRooms.KidsRoom, HidingPlaces.KidsRoom);
        var attic = new LocationWithHidingPlace(HouseRooms.Attic, HidingPlaces.Attic);

        Entry.AddExit(Direction.Out, garage);
        Entry.AddExit(Direction.East, hallway);
        hallway.AddExit(Direction.Northwest, kitchen);
        hallway.AddExit(Direction.North, bathroom);
        hallway.AddExit(Direction.South, livingRoom);
        hallway.AddExit(Direction.Up, landing);
        landing.AddExit(Direction.Northwest, masterBedroom);
        masterBedroom.AddExit(Direction.East, masterBathroom);
        landing.AddExit(Direction.West, secondBathroom);
        landing.AddExit(Direction.Southwest, nursery);
        landing.AddExit(Direction.South, pantry);
        landing.AddExit(Direction.Southeast, kidsRoom);
        landing.AddExit(Direction.Up, attic);

        Locations.AddRange([
            Entry, garage, hallway, kitchen, bathroom, livingRoom, landing, masterBedroom, masterBathroom,
            secondBathroom, nursery, pantry, kidsRoom, attic
        ]);
    }

    public static Location GetLocationByName(string name) {
        Location location = Locations.FirstOrDefault(l => l.Name.Equals(name)) ?? Entry;

        return location;
    }

    public static Location RandomExit(Location location) {
        IDictionary<Direction, Location> exits = location.Exits;
        Location randomExit = exits.OrderBy(pair => pair.Value.Name).Skip(Random.Next(0, exits.Count)).First().Value;

        return randomExit;
    }

    public static void ClearHidingPlaces() {
        foreach (Location location in Locations) {
            if (location is not LocationWithHidingPlace hidingPlace) continue;

            hidingPlace.CheckHidingPlace();
        }
    }
}
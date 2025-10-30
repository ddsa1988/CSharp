using HideAndSeek.Enums;
using HideAndSeek.Services;

namespace HideAndSeek.Models;

public static class House {
    public static readonly Location Entry;

    static House() {
        Entry = new Location(HouseRooms.Entry);
        CreateLayout();
    }

    private static void CreateLayout() {
        var garage = new Location(HouseRooms.Garage);
        var hallway = new Location(HouseRooms.Hallway);
        var kitchen = new Location(HouseRooms.Kitchen);
        var bathroom = new Location(HouseRooms.Bathroom);
        var livingRoom = new Location(HouseRooms.LivingRoom);
        var landing = new Location(HouseRooms.Landing);
        var masterBedroom = new Location(HouseRooms.MasterBedroom);
        var masterBathroom = new Location(HouseRooms.MasterBathroom);
        var secondBathroom = new Location(HouseRooms.SecondBathroom);
        var nursery = new Location(HouseRooms.Nursery);
        var pantry = new Location(HouseRooms.Pantry);
        var kidsRoom = new Location(HouseRooms.KidsRoom);
        var attic = new Location(HouseRooms.Attic);

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
    }
}
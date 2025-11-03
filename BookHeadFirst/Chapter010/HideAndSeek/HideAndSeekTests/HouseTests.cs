using HideAndSeek.Enums;
using HideAndSeek.Models;
using HideAndSeek.Services;

namespace HideAndSeekTests;

[TestClass]
public class HouseTests {
    [TestMethod]
    public void TestLayout() {
        Assert.AreEqual(HouseRooms.Entry, House.Entry.Name);

        Location garage = House.Entry.GetExit(Direction.Out);
        Assert.AreEqual(HouseRooms.Garage, garage.Name);

        Location hallway = House.Entry.GetExit(Direction.East);
        Assert.AreEqual(HouseRooms.Hallway, hallway.Name);

        Location kitchen = hallway.GetExit(Direction.Northwest);
        Assert.AreEqual(HouseRooms.Kitchen, kitchen.Name);

        Location bathroom = hallway.GetExit(Direction.North);
        Assert.AreEqual(HouseRooms.Bathroom, bathroom.Name);

        Location livingRoom = hallway.GetExit(Direction.South);
        Assert.AreEqual(HouseRooms.LivingRoom, livingRoom.Name);

        Location landing = hallway.GetExit(Direction.Up);
        Assert.AreEqual(HouseRooms.Landing, landing.Name);

        Location masterBedroom = landing.GetExit(Direction.Northwest);
        Assert.AreEqual(HouseRooms.MasterBedroom, masterBedroom.Name);

        Location masterBathroom = masterBedroom.GetExit(Direction.East);
        Assert.AreEqual(HouseRooms.MasterBathroom, masterBathroom.Name);

        Location secondBathroom = landing.GetExit(Direction.West);
        Assert.AreEqual(HouseRooms.SecondBathroom, secondBathroom.Name);

        Location nursery = landing.GetExit(Direction.Southwest);
        Assert.AreEqual(HouseRooms.Nursery, nursery.Name);

        Location pantry = landing.GetExit(Direction.South);
        Assert.AreEqual(HouseRooms.Pantry, pantry.Name);

        Location kidsRoom = landing.GetExit(Direction.Southeast);
        Assert.AreEqual(HouseRooms.KidsRoom, kidsRoom.Name);

        Location attic = landing.GetExit(Direction.Up);
        Assert.AreEqual(HouseRooms.Attic, attic.Name);
    }

    [TestMethod]
    public void TestGetLocationByName() {
        Assert.AreEqual(HouseRooms.Entry, House.GetLocationByName(HouseRooms.Entry).Name);
        Assert.AreEqual(HouseRooms.Attic, House.GetLocationByName(HouseRooms.Attic).Name);
        Assert.AreEqual(HouseRooms.Garage, House.GetLocationByName(HouseRooms.Garage).Name);
        Assert.AreEqual(HouseRooms.MasterBedroom, House.GetLocationByName(HouseRooms.MasterBedroom).Name);
        Assert.AreEqual("Entry", House.GetLocationByName("Secret Library").Name);
    }

    [TestMethod]
    public void TestRandomExit() {
        Location landing = House.GetLocationByName(HouseRooms.Landing);

        House.Random = new MockRandom() { ValueToReturn = 0 };
        Assert.AreEqual(HouseRooms.Attic, House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 1 };
        Assert.AreEqual(HouseRooms.Hallway, House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 2 };
        Assert.AreEqual(HouseRooms.KidsRoom, House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 3 };
        Assert.AreEqual(HouseRooms.MasterBedroom, House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 5 };
        Assert.AreEqual(HouseRooms.Pantry, House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 6 };
        Assert.AreEqual(HouseRooms.SecondBathroom, House.RandomExit(landing).Name);

        Location kitchen = House.GetLocationByName(HouseRooms.Kitchen);
        House.Random = new MockRandom() { ValueToReturn = 0 };
        Assert.AreEqual(HouseRooms.Hallway, House.RandomExit(kitchen).Name);
    }

    [TestMethod]
    public void TestHidingPlaces() {
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.Garage), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.Kitchen), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.LivingRoom), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.Bathroom), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.MasterBedroom),
            typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.MasterBathroom), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.SecondBathroom),
            typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.KidsRoom), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.Nursery), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.Pantry), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName(HouseRooms.Attic), typeof(LocationWithHidingPlace));
    }

    [TestMethod]
    public void TestClearHidingPlaces() {
        var garage = House.GetLocationByName(HouseRooms.Garage) as LocationWithHidingPlace;
        garage?.Hide(new Opponent("Opponent1"));

        var attic = House.GetLocationByName(HouseRooms.Garage) as LocationWithHidingPlace;
        attic?.Hide(new Opponent("Opponent2"));
        attic?.Hide(new Opponent("Opponent3"));
        attic?.Hide(new Opponent("Opponent4"));

        House.ClearHidingPlaces();

        Assert.AreEqual(0, garage?.CheckHidingPlace().Count());
        Assert.AreEqual(0, attic?.CheckHidingPlace().Count());
    }
}
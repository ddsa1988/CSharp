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
        Assert.AreEqual("Entry", House.GetLocationByName("Ent").Name);
        Assert.AreEqual("Entry", House.GetLocationByName("Entry").Name);
        Assert.AreEqual("Attic", House.GetLocationByName("Attic").Name);
        Assert.AreEqual("Garage", House.GetLocationByName("Garage").Name);
        Assert.AreEqual("Master Bedroom", House.GetLocationByName("Master Bedroom").Name);
        Assert.AreEqual("Entry", House.GetLocationByName("Secret Library").Name);
    }

    [TestMethod]
    public void TestRandomExit() {
        Location landing = House.GetLocationByName("Landing");

        House.Random = new MockRandom() { ValueToReturn = 0 };
        Assert.AreEqual("Attic", House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 1 };
        Assert.AreEqual("Hallway", House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 2 };
        Assert.AreEqual("Kids Room", House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 3 };
        Assert.AreEqual("Master Bedroom", House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 5 };
        Assert.AreEqual("Pantry", House.RandomExit(landing).Name);

        House.Random = new MockRandom() { ValueToReturn = 6 };
        Assert.AreEqual("Second Bathroom", House.RandomExit(landing).Name);

        Location kitchen = House.GetLocationByName("Kitchen");
        House.Random = new MockRandom() { ValueToReturn = 0 };
        Assert.AreEqual("Hallway", House.RandomExit(kitchen).Name);
    }

    [TestMethod]
    public void TestHidingPlaces() {
        Assert.IsInstanceOfType(House.GetLocationByName("Garage"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Kitchen"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Living Room"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Bathroom"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Master Bedroom"),
            typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Master Bath"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Second Bathroom"),
            typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Kids Room"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Nursery"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Pantry"), typeof(LocationWithHidingPlace));
        Assert.IsInstanceOfType(House.GetLocationByName("Attic"), typeof(LocationWithHidingPlace));
    }

    [TestMethod]
    public void TestClearHidingPlaces() {
        var garage = House.GetLocationByName("Garage") as LocationWithHidingPlace;
        garage?.Hide(new Opponent("Opponent1"));

        var attic = House.GetLocationByName("Garage") as LocationWithHidingPlace;
        attic?.Hide(new Opponent("Opponent2"));
        attic?.Hide(new Opponent("Opponent3"));
        attic?.Hide(new Opponent("Opponent4"));

        House.ClearHidingPlaces();

        Assert.AreEqual(0, garage?.CheckHidingPlace().Count());
        Assert.AreEqual(0, attic?.CheckHidingPlace().Count());
    }
}
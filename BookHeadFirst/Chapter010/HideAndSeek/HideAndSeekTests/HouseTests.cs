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
}
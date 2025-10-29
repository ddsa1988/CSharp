using HideAndSeek.Enums;
using HideAndSeek.Models;

namespace HideAndSeekTests;

[TestClass]
public class LocationTests {
    private const string CenterRoom = "Center Room";
    private readonly Location _center = new(CenterRoom);

    /// <summary>
    /// Initializes each unit test by setting creating a new the center location
    /// and adding a room in each direction before the test
    /// </summary>
    [TestInitialize]
    public void Initialize() {
        Assert.AreSame(CenterRoom, _center.ToString());
        Assert.AreEqual(0, _center.ExitList.Count());

        _center.AddExit(Direction.North, new Location("North Room"));
        _center.AddExit(Direction.East, new Location("East Room"));
        _center.AddExit(Direction.South, new Location("South Room"));
        _center.AddExit(Direction.West, new Location("West Room"));
        _center.AddExit(Direction.Northeast, new Location("Northeast Room"));
        _center.AddExit(Direction.Southeast, new Location("Southeast Room"));
        _center.AddExit(Direction.Northwest, new Location("Northwest Room"));
        _center.AddExit(Direction.Southwest, new Location("Southwest Room"));
        _center.AddExit(Direction.Up, new Location("Upstairs Room"));
        _center.AddExit(Direction.Down, new Location("Downstairs Room"));

        Assert.AreEqual(10, _center.ExitList.Count());
    }

    /// <summary>
    /// Make sure GetExit returns the location in a direction only if it exists
    /// </summary>
    [TestMethod]
    public void TestGetExit() {
        Location eastRoom = _center.GetExit(Direction.East);

        Assert.AreEqual("East Room", eastRoom.Name);
        Assert.AreSame(_center, eastRoom.GetExit(Direction.West));
        Assert.AreSame(eastRoom, eastRoom.GetExit(Direction.Up));
    }

    /// <summary>
    /// Validates that the exit lists are working
    /// </summary>
    [TestMethod]
    public void TestExitList() {
        List<string> expectedList = [
            "- the Upstairs Room is Up",
            "- the Southeast Room is to the Southeast",
            "- the Northeast Room is to the Northeast",
            "- the East Room is to the East",
            "- the North Room is to the North",
            "- the South Room is to the South",
            "- the West Room is to the West",
            "- the Southwest Room is to the Southwest",
            "- the Northwest Room is to the Northwest",
            "- the Downstairs Room is Down"
        ];

        CollectionAssert.AreEqual(expectedList, _center.ExitList.ToList());
    }

    /// <summary>
    /// Validates that each room’s name and return exit is created correctly
    /// </summary>
    [TestMethod]
    public void TestReturnExits() {
        // This test will test navigating through the center Location
    }

    /// <summary>
    /// Add a hall to one of the rooms and make sure the hall room’s names
    /// and return exits are created correctly
    /// </summary>
    [TestMethod]
    public void TestAddHall() {
        // This test will add a hallway with two locations and make sure they work
    }
}
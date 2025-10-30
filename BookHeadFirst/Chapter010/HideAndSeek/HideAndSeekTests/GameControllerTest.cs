using HideAndSeek.Enums;
using HideAndSeek.Models;
using HideAndSeek.Services;

namespace HideAndSeekTests;

[TestClass]
public class GameControllerTest {
    private GameController? _gameController;

    [TestInitialize]
    public void Initialize() {
        _gameController = new GameController();
    }

    [TestMethod]
    public void TestMovement() {
        if (_gameController == null) return;

        Assert.AreEqual(HouseRooms.Entry, _gameController.CurrentLocation.Name);

        Assert.IsFalse(_gameController.Move(Direction.Up));
        Assert.AreEqual(HouseRooms.Entry, _gameController.CurrentLocation.Name);

        Assert.IsTrue(_gameController.Move(Direction.East));
        Assert.AreEqual(HouseRooms.Hallway, _gameController.CurrentLocation.Name);

        Assert.IsTrue(_gameController.Move(Direction.Up));
        Assert.AreEqual(HouseRooms.Landing, _gameController.CurrentLocation.Name);
    }

    [TestMethod]
    public void TestParseInt() {
        if (_gameController == null) return;

        string initialStatus = _gameController.Status;

        Assert.AreEqual("That's not a valid direction", _gameController.ParseInput("X"));
        Assert.AreEqual(initialStatus, _gameController.Status);

        Assert.AreEqual("There's no exit in that direction", _gameController.ParseInput("Up"));
        Assert.AreEqual(initialStatus, _gameController.Status);

        Assert.AreEqual("Moving East", _gameController.ParseInput("East"));

        Assert.AreEqual("You are in the Hallway. You see the following exits:" +
                        Environment.NewLine + "- the Landing is Up" +
                        Environment.NewLine + "- the Bathroom is to the North" +
                        Environment.NewLine + "- the Living Room is to the South" +
                        Environment.NewLine + "- the Entry is to the West" +
                        Environment.NewLine + "- the Kitchen is to the Northwest", _gameController.Status);

        Assert.AreEqual("Moving South", _gameController.ParseInput("South"));

        Assert.AreEqual(
            "You are in the Living Room. You see the following exits:" + Environment.NewLine +
            "- the Hallway is to the North", _gameController.Status);
    }
}
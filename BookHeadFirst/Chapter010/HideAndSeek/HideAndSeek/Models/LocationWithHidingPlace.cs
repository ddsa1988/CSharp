namespace HideAndSeek.Models;

public class LocationWithHidingPlace : Location {
    private List<Opponent> _hiddenOpponents;
    public string HidingPlace { get; }

    public LocationWithHidingPlace(string name, string hidingPlace) : base(name) {
        HidingPlace = hidingPlace;
        _hiddenOpponents = [];
    }

    public void Hide(Opponent opponent) {
        _hiddenOpponents.Add(opponent);
    }

    public IEnumerable<Opponent> CheckHidingPlace() {
        IEnumerable<Opponent> foundOpponents = new List<Opponent>(_hiddenOpponents);
        _hiddenOpponents.Clear();

        return foundOpponents;
    }

    public override string ToString() => Name;
}
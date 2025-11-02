namespace HideAndSeek.Models;

public class LocationWithHidingPlace : Location {
    public string HidingPlace { get; }

    public LocationWithHidingPlace(string name, string hidingPlace) : base(name) {
        HidingPlace = hidingPlace;
    }

    public void Hide(Opponent opponent) {
        throw new NotImplementedException();
    }

    public IEnumerable<Opponent> CheckHidingPlace() {
        throw new NotImplementedException();
    }
}
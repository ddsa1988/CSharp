using HideAndSeek.Services;

namespace HideAndSeek.Models;

public static class House {
    public static readonly Location Entry;

    static House() {
        Entry = new Location(HouseRooms.Entry);
    }
}
using PartyInvites.Mapping;
using PartyInvites.Models;

namespace PartyInvites.Repository;

public static class Repository {
    private static readonly char Sep = Path.DirectorySeparatorChar;
    private static readonly string FilePath = $"Repository{Sep}Data{Sep}GuestResponses.txt";

    public static void WriteGuestResponse(string json) {
        // Console.WriteLine(Path.GetFullPath(filePath));

        if (!File.Exists(FilePath)) {
            File.Create(FilePath).Close();
        }

        using StreamWriter sw = File.AppendText(FilePath);
        sw.WriteLine(json);
    }

    public static IEnumerable<GuestResponse> GetGuestResponses() {
        var guestResponses = new List<GuestResponse>();

        if (!File.Exists(FilePath)) {
            return guestResponses.AsEnumerable();
        }

        using var sr = new StreamReader(FilePath);

        while (!sr.EndOfStream) {
            string? line = sr.ReadLine();

            GuestResponse? guestResponse = line?.GuestResponseFromJson();

            if (guestResponse == null) continue;

            guestResponses.Add(guestResponse);
        }

        return guestResponses.AsEnumerable();
    }
}
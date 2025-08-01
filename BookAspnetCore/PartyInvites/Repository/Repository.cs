using PartyInvites.Mapping;
using PartyInvites.Models;

namespace PartyInvites.Repository;

public static class Repository {
    private static readonly char Sep = Path.DirectorySeparatorChar;
    private static readonly string FolderPath = $"Repository{Sep}Data";
    private static readonly string FilePath = $"{FolderPath}{Sep}GuestResponses.txt";

    public static async Task WriteGuestResponse(string json) {
        if (!Directory.Exists(FolderPath)) {
            try {
                Directory.CreateDirectory(FolderPath);
            } catch (Exception ex) {
                Console.WriteLine("Error to create directory: " + ex.Message);
                return;
            }
        }

        if (!File.Exists(FilePath)) {
            try {
                File.Create(FilePath).Close();
            } catch (Exception ex) {
                Console.WriteLine("Error to create file: " + ex.Message);
                return;
            }
        }

        await using StreamWriter sw = File.AppendText(FilePath);
        await sw.WriteLineAsync(json);
    }

    public static async Task<IEnumerable<GuestResponse>> GetGuestResponses() {
        var guestResponses = new List<GuestResponse>();

        if (!File.Exists(FilePath)) {
            return guestResponses.AsEnumerable();
        }

        using var sr = new StreamReader(FilePath);

        while (!sr.EndOfStream) {
            string? line = await sr.ReadLineAsync();

            GuestResponse? guestResponse = line?.GuestResponseFromJson();

            if (guestResponse == null) continue;

            guestResponses.Add(guestResponse);
        }

        return guestResponses.AsEnumerable();
    }
}
namespace NoteTakingConsoleApp.Entities;

public class Note {
    private static int counter = 0;
    public int Id { get; private set; }
    public string Text { get; set; } = "";

    public Note(string text) {
        Id = ++counter;
        Text = text;
    }

    public override bool Equals(object? obj) {
        if (obj is not Note) return false;

        Note? other = obj as Note;

        return Id == other?.Id;
    }

    public override int GetHashCode() {
        return Id;
    }

    public override string ToString() {
        return Id + "," + Text;
    }
}

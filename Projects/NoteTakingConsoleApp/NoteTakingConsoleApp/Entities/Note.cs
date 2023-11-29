namespace NoteTakingConsoleApp.Entities;

public class Note {
    private static int counter = 0; 
    public int Id { get; private set; }
    public string Text { get; set; } = "";

    public Note(string text) {
        Id = ++counter;
        Text = text;
    }

    public override string ToString() {
        return "Id: " + Id +
            " Text: " + Text;
    }
}

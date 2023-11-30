using System.Text;

namespace NoteTakingConsoleApp.Entities;

public class NoteBook {
    private List<Note> notes = new List<Note>();

    public bool AddNote(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return false;

        Note note = new Note(text);
        notes.Add(note);

        return true;
    }

    public bool RemoveNote(int id) {
        return false;
    }

    public override string ToString() {
        if (notes.Count == 0) return "";

        StringBuilder sb = new StringBuilder();

        foreach (Note note in notes) {
            sb.Append(note.ToString() + "\n");
        }

        return sb.ToString();
    }
}

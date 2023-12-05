using System.Text;

namespace NoteTakingConsoleApp.Entities;

public class Notebook {
    private readonly List<string> notes = new List<string>();
    private readonly ManageDb manageDb;
    
    public Notebook(string sourcePath) {
        manageDb = new ManageDb(sourcePath);
        manageDb.ReadDb(notes);
    }
    
    public bool AddNote(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return false;

        notes.Add(text);
        manageDb.UpdateDb(notes);
        
        return true;
    }

    public bool RemoveNote(int index) {
        if (index < 1 || index > notes.Count) return false;

        notes.RemoveAt(index - 1);
        manageDb.UpdateDb(notes);

        return true;
    }

    public override string ToString() {
        if (notes.Count == 0) return "";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < notes.Count; i++) {
            sb.Append(i + 1 + " - " + notes[i] + "\n");
        }

        return sb.ToString();
    }
}
using System.Data;

namespace SQLite;

public class Program {
    public static void Main(string[] args) {
        char separator = Path.AltDirectorySeparatorChar;
        const string databaseName = "Database.sqlite";
        const string tableName = "Clients";
        string sourcePath = @$"..{separator}..{separator}..{separator}Database{separator}{databaseName}";

        Database db = new Database(sourcePath, tableName);
        db.CreateDatabase();
        db.CreateTable();
        db.AddClient("diego");
        db.AddClient("Amanda");

        db.GetClients();
    }
}
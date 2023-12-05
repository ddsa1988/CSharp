using System.Data.SQLite;

namespace SQLite;

public class Database {
    private SQLiteConnection? sqliteConnection;
    private string SourcePath { get; set; }
    private string TableName { get; set; }

    public Database(string sourcePath, string tableName) {
        SourcePath = sourcePath;
        TableName = tableName;
    }

    private SQLiteConnection DbConnection() {
        sqliteConnection = new SQLiteConnection($"Data Source = {SourcePath}; Version = 3");
        return sqliteConnection;
    }

    public bool CreateDatabase() {
        bool status = true;

        try {
            if (!File.Exists(SourcePath)) {
                SQLiteConnection.CreateFile(SourcePath);
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            status = false;
        }

        return status;
    }

    public bool CreateTable() {
        string createQuery =
            $"CREATE TABLE IF NOT EXISTS {TableName} (ID INTEGER(16) PRIMARY KEY AUTOINCREMENT NOT NULL, NAME VARCHAR(50) UNIQUE NOT NULL)";

        try {
            using SQLiteCommand cmd = DbConnection().CreateCommand();
            cmd.CommandText = createQuery;
            ExecuteQuery(cmd);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            return false;
        }

        return true;
    }

    public bool AddClient(string name) {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return false;

        bool status = true;
        string insertQuery = $"INSERT INTO {TableName} (Name) VALUES (@name)";

        try {
            using SQLiteCommand cmd = DbConnection().CreateCommand();
            cmd.CommandText = insertQuery;
            cmd.Parameters.AddWithValue("@name", name.ToUpper());
            ExecuteQuery(cmd);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            status = false;
        }

        return status;
    }

    public bool GetClients() {
        bool status = true;
        string getQuery = $"SELECT * FROM {TableName}";

        using SQLiteCommand cmd = new SQLiteCommand(getQuery, DbConnection());

        try {
            cmd.Connection.Open();
            cmd.CommandText = getQuery;

            SQLiteDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read()) {
                long id = (long)dataReader[dataReader.GetName(0)];
                string? name = dataReader[dataReader.GetName(1)].ToString();

                Console.WriteLine($"ID = {id}, Name = {name}");
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            status = false;
        }

        cmd.Connection.Close();
        return status;
    }

    private void ExecuteQuery(SQLiteCommand cmd) {
        cmd.Connection.Open();
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
    }
}
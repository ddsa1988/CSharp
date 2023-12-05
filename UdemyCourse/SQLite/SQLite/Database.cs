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
        bool status = true;
        string createQuery =
            $"CREATE TABLE IF NOT EXISTS {TableName} (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, NAME VARCHAR(50) UNIQUE NOT NULL)";

        try {
            using SQLiteCommand cmd = DbConnection().CreateCommand();
            cmd.CommandText = createQuery;
            ExecuteQuery(cmd);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            status = false;
        }

        return status;
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

    public bool UpdateClient(long id, string name) {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return false;
        if(id < 1) return false;

        bool status = true;
        string updateQuery = $"UPDATE {TableName} SET NAME=@name WHERE ID=@id";

        try {
            using SQLiteCommand cmd = DbConnection().CreateCommand();
            cmd.CommandText = updateQuery;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name.ToUpper());
            ExecuteQuery(cmd);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            status = false;
        }

        return status;
    }

    public bool DeleteClient(long id) {
        if (id < 1) return false;

        bool status = true;
        string deleteQuery = $"DELETE FROM {TableName} WHERE ID=@id";

        try {
            using SQLiteCommand cmd = DbConnection().CreateCommand();
            cmd.CommandText = deleteQuery;
            cmd.Parameters.AddWithValue("@id", id);
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

    public bool GetClient(long clientId) {
        bool status = true;
        string getQuery = $"SELECT * FROM {TableName} WHERE ID={clientId}";

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
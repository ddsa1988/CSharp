using Section015_hashSetExercises.Entities;

namespace Section015_hashSetExercises; 

public class Exercise001 {
    public static void MyMain() {

        char separator = Path.AltDirectorySeparatorChar;
        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Logs.txt";
        HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

        if (File.Exists(sourcePath)) {
            
            try {
                using StreamReader sr = new StreamReader(sourcePath);
                
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    string[] lineArr = line.Split(" ");
                    string name = lineArr[0];
                    DateTime instant = DateTime.Parse(lineArr[1]);

                    LogRecord logRecord = new LogRecord(name, instant);

                    logRecords.Add(logRecord);
                    
                    Console.WriteLine(line);
                }
                    
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }       
        }

        Console.WriteLine("\nTotal users: " + logRecords.Count);
    }
}
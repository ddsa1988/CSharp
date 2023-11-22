using System.Globalization;

namespace Section015_hashSetExercises.Entities; 

public class LogRecord {
    
    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    public string Name { get; set; }
    public DateTime Instant { get; set; }

    public LogRecord(string name, DateTime instant) {
        Name = name;
        Instant = instant;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }
    
    public override bool Equals(object? obj) {
        if (obj is not LogRecord) {
            return false;
        }
        
        LogRecord? other = obj as LogRecord;
        
        return Name.Equals(other?.Name);
    }

    public override string ToString() {
        return "Name: " + Name +
               "\nInstant: " + Instant.ToString(cultureInfo);
    } 
}
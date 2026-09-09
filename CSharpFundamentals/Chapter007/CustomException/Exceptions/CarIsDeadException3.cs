namespace CustomException.Exceptions;

public class CarIsDeadException3 : ApplicationException {
    public DateTime ErrorTimeStamp { get; set; }
    public string CauseOfError { get; set; } = string.Empty;

    public CarIsDeadException3() { }
    public CarIsDeadException3(string cause, DateTime time) : this(cause, time, string.Empty) { }
    public CarIsDeadException3(string cause, DateTime time, string message) : this(cause, time, message, null) { }

    public CarIsDeadException3(string cause, DateTime time, string message, Exception? inner) : base(
        message, inner) {
        CauseOfError = cause;
        ErrorTimeStamp = time;
    }
}
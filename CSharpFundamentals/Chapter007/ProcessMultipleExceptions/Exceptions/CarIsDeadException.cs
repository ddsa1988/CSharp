namespace ProcessMultipleExceptions.Exceptions;

public class CarIsDeadException : ApplicationException {
    public DateTime ErrorTimeStamp { get; set; }
    public string CauseOfError { get; set; } = string.Empty;

    public CarIsDeadException() { }
    public CarIsDeadException(string cause, DateTime time) : this(cause, time, string.Empty) { }
    public CarIsDeadException(string cause, DateTime time, string message) : this(cause, time, message, null) { }

    public CarIsDeadException(string cause, DateTime time, string message, Exception? inner) : base(
        message, inner) {
        CauseOfError = cause;
        ErrorTimeStamp = time;
    }
}
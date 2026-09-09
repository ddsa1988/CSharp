namespace CustomException.Exceptions;

public class CarIsDeadException1 : ApplicationException {
    public DateTime ErrorTimeStamp { get; set; }
    public string CauseOfError { get; set; } = string.Empty;

    public CarIsDeadException1() { }

    // Feed message to parent constructor.
    public CarIsDeadException1(string cause, DateTime time, string message) : base(message) {
        CauseOfError = cause;
        ErrorTimeStamp = time;
    }
}
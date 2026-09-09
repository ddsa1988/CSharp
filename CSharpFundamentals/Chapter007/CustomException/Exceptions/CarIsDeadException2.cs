namespace CustomException.Exceptions;

public class CarIsDeadException2 : ApplicationException {
    private readonly string _message = string.Empty;
    public DateTime ErrorTimeStamp { get; set; }
    public string CauseOfError { get; set; } = string.Empty;

    public CarIsDeadException2() { }

    // Override the Exception.Message property
    public CarIsDeadException2(string cause, DateTime time, string message) {
        CauseOfError = cause;
        ErrorTimeStamp = time;
        _message = message;
    }

    public override string Message => $"Car error message: {_message}";
}
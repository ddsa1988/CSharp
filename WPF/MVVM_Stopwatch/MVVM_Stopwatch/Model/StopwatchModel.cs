namespace MVVM_Stopwatch.Model;

public class StopwatchModel {
    private DateTime _startedTime;

    /// <summary>
    /// The constructor reset the stopwatch
    /// </summary>
    public StopwatchModel() {
        Reset();
    }

    /// <summary>
    /// Returns true if the stopwatch is running
    /// </summary>
    public bool Running {
        get => _startedTime != DateTime.MinValue;
        set {
            if (!value || Running) return;
            _startedTime = DateTime.Now;
        }
    }

    /// <summary>
    /// Returns the elapsed time, or zero if the stop watch is not running
    /// </summary>
    public TimeSpan ElapsedTime => Running ? DateTime.Now - _startedTime : TimeSpan.Zero;

    /// <summary>
    /// Resets the stopwatch by setting its started time to DateTime.MinValue
    /// </summary>
    public void Reset() => _startedTime = DateTime.MinValue;
}
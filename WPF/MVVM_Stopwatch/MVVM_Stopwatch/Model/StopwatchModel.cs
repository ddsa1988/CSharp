namespace MVVM_Stopwatch.Model;

public class StopwatchModel {
    private DateTime _startedTime;
    private bool _paused;
    private DateTime _pausedAt;
    private TimeSpan _totalPausedTime;

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
        get => _startedTime != DateTime.MinValue && !_paused;
        set {
            if (value) {
                _paused = false;

                if (_pausedAt != DateTime.MinValue) {
                    _totalPausedTime += DateTime.Now - _pausedAt;
                }

                if (_startedTime != DateTime.MinValue) return;

                _startedTime = DateTime.Now;
            }
            else {
                _paused = true;
                _pausedAt = DateTime.Now;
            }
        }
    }

    /// <summary>
    /// Returns the elapsed time, or zero if the stop watch is not running
    /// </summary>
    public TimeSpan ElapsedTime {
        get {
            if (_paused) return _pausedAt - _startedTime - _totalPausedTime;
            if (_startedTime != DateTime.MinValue) return DateTime.Now - _startedTime - _totalPausedTime;
            return TimeSpan.Zero;
        }
    }

    /// <summary>
    /// Resets the stopwatch by setting its started time to DateTime.MinValue
    /// </summary>
    public void Reset() {
        _startedTime = DateTime.MinValue;
        _paused = false;
        _pausedAt = DateTime.MinValue;
        _totalPausedTime = TimeSpan.Zero;
    }
}
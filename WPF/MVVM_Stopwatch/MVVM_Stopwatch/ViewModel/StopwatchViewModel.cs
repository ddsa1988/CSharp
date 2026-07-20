using MVVM_Stopwatch.Model;

namespace MVVM_Stopwatch.ViewModel;

public class StopwatchViewModel {
    private readonly StopwatchModel _model = new();
    private const string TimeFormat = "D2";

    public void StartStop() => _model.Running = !_model.Running;
    public void Reset() => _model.Reset();
    public string Hours => _model.ElapsedTime.Hours.ToString(TimeFormat);
    public string Minutes => _model.ElapsedTime.Minutes.ToString(TimeFormat);
    public string Seconds => _model.ElapsedTime.Seconds.ToString(TimeFormat);
    public string Tenths => ((int)(_model.ElapsedTime.Milliseconds / 100M)).ToString();
}
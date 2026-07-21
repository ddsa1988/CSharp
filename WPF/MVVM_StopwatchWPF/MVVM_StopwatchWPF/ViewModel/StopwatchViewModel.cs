using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM_StopwatchWPF.Model;

namespace MVVM_StopwatchWPF.ViewModel;

public sealed class StopwatchViewModel : INotifyPropertyChanged {
    private readonly StopwatchModel _model = new();
    private const string TimeFormat = "D2";

    public void StartStop() => _model.Running = !_model.Running;
    public void Reset() => _model.Reset();
    public string Hours => _model.ElapsedTime.Hours.ToString(TimeFormat);
    public string Minutes => _model.ElapsedTime.Minutes.ToString(TimeFormat);
    public string Seconds => _model.ElapsedTime.Seconds.ToString(TimeFormat);
    public string Tenths => ((int)(_model.ElapsedTime.Milliseconds / 100M)).ToString();
    public void LapTime() => _model.SetLapTime();
    public string LapHours => _model.LapTime.Hours.ToString(TimeFormat);
    public string LapMinutes => _model.LapTime.Minutes.ToString(TimeFormat);
    public string LapSeconds => _model.LapTime.Seconds.ToString(TimeFormat);
    public string LapTenths => ((int)(_model.LapTime.Milliseconds / 100M)).ToString();
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
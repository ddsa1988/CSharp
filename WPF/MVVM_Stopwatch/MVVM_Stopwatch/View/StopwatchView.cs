using MVVM_Stopwatch.ViewModel;

namespace MVVM_Stopwatch.View;

public class StopwatchView {
    private StopwatchViewModel _viewModel = new();
    private bool _quit = false;

    /// <summary>
    /// Clears the console and displays the stopwatch
    /// </summary>
    public StopwatchView() {
        ClearScreenAndAddHelpMessage();

        TimerCallback timerCallback = UpdateTimeCallback;
        var timer = new Timer(timerCallback, null, 0, 10);

        while (!_quit) {
            Thread.Sleep(100);
        }

        Console.CursorVisible = true;
    }

    /// <summary>
    /// Clears the screen, adds the help message to fourth row, and makes the cursor invisible
    /// </summary>
    private static void ClearScreenAndAddHelpMessage() {
        Console.Clear();
        Console.CursorTop = 3; // This moves the cursor to the fourth row (rows start at 0)
        Console.WriteLine("Space to start, R to reset, any other key to quit");
        Console.CursorVisible = false;
    }

    /// <summary>
    /// Callback to update the time display that the timer calls each time it ticks
    /// </summary>
    /// <param name="state"></param>
    public void UpdateTimeCallback(object? state) => throw new NotImplementedException();
}
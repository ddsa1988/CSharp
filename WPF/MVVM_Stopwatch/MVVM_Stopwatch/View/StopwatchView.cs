using MVVM_Stopwatch.ViewModel;

namespace MVVM_Stopwatch.View;

public class StopwatchView {
    private readonly StopwatchViewModel _viewModel = new();
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
    /// Writes the current time to the second rwo and 23rd column of the screen
    /// </summary>
    private void WriteCurrentTime() {
        Console.CursorTop = 1; // This moves the cursor to the second row (rows start at 0)
        Console.CursorLeft = 23; // This moves the cursor to the 23rd column (starting at 0)
        string time = $"{_viewModel.Hours}:{_viewModel.Minutes}:{_viewModel.Seconds}.{_viewModel.Tenths}";
        Console.Write(time);
    }

    /// <summary>
    /// Callback to update the time display that the timer calls each time it ticks
    /// </summary>
    /// <param name="state"></param>
    private void UpdateTimeCallback(object? state) {
        WriteCurrentTime();

        if (!Console.KeyAvailable) return;

        char userInput = char.ToLower(Console.ReadKey(true).KeyChar);

        switch (userInput) {
            case ' ':
                _viewModel.StartStop();
                break;
            case 'r':
                _viewModel.Reset();
                break;
            default:
                Console.CursorVisible = true;
                Console.CursorLeft = 0;
                Console.CursorTop = 5;
                _quit = true;
                break;
        }
    }
}
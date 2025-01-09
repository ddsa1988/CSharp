namespace Basics.S001_FirstApp;

public static class ShowEnvironmentDetails {
    public static void UserMain() {
        foreach (string drive in Environment.GetLogicalDrives()) {
            Console.Write(drive + "; ");
        }
        
        Console.WriteLine('\n');
        
        Console.WriteLine($"User name: {Environment.UserName}");
        Console.WriteLine($"Machine name: {Environment.MachineName}");
        Console.WriteLine($"OS: {Environment.OSVersion}");
        Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
        Console.WriteLine($".Net Core Version: {Environment.Version}");
    }
}
namespace Basics.S002_SystemConsole;

public static class FormatNumericalData {
    public static void UserMain() {
        const float fNumber = 9.757693f;
        const int iNumber = 255;

        string msg = string.Format("127 in hex is {0:X}.", 127);

        Console.WriteLine("Float number raw: " + fNumber);
        Console.WriteLine("Float number three decimal places: {0:F3}", fNumber);
        Console.WriteLine("Float number in currency: {0:C2}\n", fNumber);

        Console.WriteLine("Integer number: " + iNumber);
        Console.WriteLine("Integer number in hexadecimal: {0:X}\n", iNumber);

        Console.WriteLine(msg);
    }
}
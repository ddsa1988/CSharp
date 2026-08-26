using SimpleClassExample.Models;

namespace SimpleClassExample.Examples;

internal static class CreatingObjects {
    internal static void Run() {
        var myCar = new Car("Diego", 20);

        myCar.PrintState();
        myCar.SpeedUp(30);
        myCar.PrintState();
    }
}
using CustomException.Exceptions;
using CustomException.Models;

namespace CustomException.Examples;

internal static class SimpleException {
    internal static void Run() {
        var myCar = new Car("Zippy", 20);
        myCar.CrankTunes(true);

        try {
            for (int i = 0; i < 10; i++) {
                myCar.Accelerate(10);
            }
        }
        catch (CarIsDeadException3 e) {
            Console.WriteLine("\nError!");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.ErrorTimeStamp);
            Console.WriteLine(e.CauseOfError);
        }
    }
}
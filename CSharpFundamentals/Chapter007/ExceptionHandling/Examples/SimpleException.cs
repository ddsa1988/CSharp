using ExceptionHandling.Models;

namespace ExceptionHandling.Examples;

internal static class SimpleException {
    internal static void Run() {
        var myCar = new Car("Zippy", 20);
        myCar.CrankTunes(true);

        for (int i = 0; i < 10; i++) {
            myCar.Accelerate(10);
        }
    }
}
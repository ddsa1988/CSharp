using System.Collections;
using ProcessMultipleExceptions.Exceptions;
using ProcessMultipleExceptions.Models;

namespace ProcessMultipleExceptions.Examples;

internal static class SimpleException {
    internal static void Run() {
        var myCar = new Car("Zippy", 20);
        myCar.CrankTunes(true);

        try {
            myCar.Accelerate(-10);
        }
        catch (CarIsDeadException e) {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e) {
            Console.WriteLine(e.Message);
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
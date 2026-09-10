using ProcessMultipleExceptions.Exceptions;
using ProcessMultipleExceptions.Models;

namespace ProcessMultipleExceptions.Examples;

internal static class InnerExceptions {
    internal static void Run() {
        var myCar = new Car("Zippy", 20);
        myCar.CrankTunes(true);

        try {
            myCar.Accelerate(200);
        }
        catch (CarIsDeadException e) {
            Console.WriteLine(e.Message);

            try {
                FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            }
            catch (Exception ex) {
                throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, ex.Message, ex);
            }
        }
        catch (ArgumentOutOfRangeException e) {
            Console.WriteLine(e.Message);
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
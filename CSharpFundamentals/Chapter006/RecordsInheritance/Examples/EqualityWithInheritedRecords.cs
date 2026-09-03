using RecordsInheritance.Models;

namespace RecordsInheritance.Examples;

internal static class EqualityWithInheritedRecords {
    internal static void Run() {
        var myMotorCycle = new MotorCycleRecord("Honda", "Pilot");
        var myScooter = new ScooterRecord("Honda", "Pilot");
        MotorCycleRecord motorcycleRef = new ScooterRecord("Honda", "Pilot");

        Console.WriteLine(myMotorCycle.Equals(myScooter));
        Console.WriteLine(myMotorCycle == myScooter);

        Console.WriteLine(myMotorCycle.Equals(motorcycleRef));
        Console.WriteLine(myMotorCycle == motorcycleRef);

        Console.WriteLine(myScooter.Equals(motorcycleRef));
        Console.WriteLine(myScooter == motorcycleRef);
    }
}
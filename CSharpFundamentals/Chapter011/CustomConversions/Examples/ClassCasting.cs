using CustomConversions.Models;

namespace CustomConversions.Examples;

internal static class ClassCasting {
    public static void Run() {
        {
            // Implicit cast between derived to base class
            Base myBaseType = new Derived();

            // Explicitly cast to store base reference in derived type
            Derived myDerivedType = (Derived)myBaseType;
        }

        {
            // Implicit cast between derived to base class
            Base myBaseType = new Base();

            // Throws InvalidCastException
            try {
                Derived myDerivedType1 = (Derived)myBaseType;
            }
            catch (InvalidCastException ex) {
                Console.WriteLine(ex.Message);
            }

            Derived? myDerivedType2 = myBaseType as Derived;
            Console.WriteLine(myDerivedType2?.ToString() ?? "null");
        }
    }
}
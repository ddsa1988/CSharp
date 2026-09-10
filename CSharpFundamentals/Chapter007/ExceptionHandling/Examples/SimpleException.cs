using System.Collections;
using ExceptionHandling.Models;

namespace ExceptionHandling.Examples;

internal static class SimpleException {
    internal static void Run() {
        var myCar = new Car("Zippy", 20);
        myCar.CrankTunes(true);

        try {
            for (int i = 0; i < 10; i++) {
                myCar.Accelerate(10);
            }
        }
        catch (Exception e) {
            Console.WriteLine("\nError!");
            Console.WriteLine("Member name: " + e.TargetSite);
            Console.WriteLine("Class defining member: " + e.TargetSite?.DeclaringType);
            Console.WriteLine("Member type: " + e.TargetSite?.MemberType);
            Console.WriteLine("Message: " + e.Message);
            Console.WriteLine("Source: " + e.Source);
            Console.WriteLine("Stack trace: " + e.StackTrace);
            Console.WriteLine("HelpLink: " + e.HelpLink);

            Console.WriteLine("Data: ");
            foreach (DictionaryEntry entry in e.Data) {
                Console.WriteLine($"=> {entry.Key}: {entry.Value}");
            }
        }
        finally {
            Console.WriteLine("The 'finally' block is always executed!");
        }

        Console.WriteLine("\nOut of the exception logic.");
    }
}
using Examples.Models;

namespace Examples;

public static class Example005 {
    public static void Run() {
        ISwimmer swimmer = new Hippo();
        IPackHunter hunter = new Wolf(false);

        {
            Hippo? hippo = swimmer as Hippo;
            Wolf? wolf = hunter as Wolf;

            Console.WriteLine(hippo != null ? "Hippo was converted." : "Hippo was not converted.");
            Console.WriteLine(wolf != null ? "Wolf was converted." : "Wolf was not converted.");
        }

        Console.WriteLine();

        {
            Hippo? hippo = hunter as Hippo;
            Wolf? wolf = swimmer as Wolf;

            Console.WriteLine(hippo != null ? "Hippo was converted." : "Hippo was not converted.");
            Console.WriteLine(wolf != null ? "Wolf was converted." : "Wolf was not converted.");
        }
    }
}
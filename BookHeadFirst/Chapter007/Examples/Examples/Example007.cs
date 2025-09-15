using Examples.Models;

namespace Examples;

public static class Example007 {
    public static void Run() {
        IClown fingersTheClown = new ScaryScary("big red nose", 14);
        fingersTheClown.Honk();

        var iScaryClownReference = fingersTheClown as IScaryClown;
        iScaryClownReference?.ScareAdults();

        // if (fingersTheClown is IScaryClown iScaryClownReference) {
        //     iScaryClownReference.ScareLittleChildren();
        // }
    }
}
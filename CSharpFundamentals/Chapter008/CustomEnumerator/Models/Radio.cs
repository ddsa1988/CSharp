namespace CustomEnumerator.Models;

internal class Radio {
    public void TurnOn(bool on) {
        Console.WriteLine(on ? "Jamming..." : "Quiet time...");
    }
}
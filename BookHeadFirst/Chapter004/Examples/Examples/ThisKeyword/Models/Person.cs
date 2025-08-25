namespace Examples.ThisKeyword.Models;

public class Person {
    public required string Name { get; init; }

    private void HearMessage(string message, Person whoSaidIt) {
        Console.WriteLine(Name + " heard a message.");
        Console.WriteLine($"{whoSaidIt.Name} said this: {message}");
    }

    public void SpeakTo(Person whoTalkTo, string message) {
        whoTalkTo.HearMessage(message, this);
    }
}
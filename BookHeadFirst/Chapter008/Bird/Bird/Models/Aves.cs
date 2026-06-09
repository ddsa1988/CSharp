namespace Bird.Models;

public class Aves {
    public string Name { get; set; } = string.Empty;


    public virtual void Fly(string destination) {
        Console.WriteLine($"{this} is flying to {destination}");
    }

    public override string ToString() {
        return $"A bird named {Name}";
    }

    public static void FlyAway(List<Aves> flock, string destination) {
        foreach (Aves bird in flock) {
            bird.Fly(destination);
        }
    }
}
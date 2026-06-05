namespace Interfaces.Models;

public abstract class Canine : IAnimal {
    public bool BelongsToPack { get; protected set; }
    public abstract void MakeNoise();
}
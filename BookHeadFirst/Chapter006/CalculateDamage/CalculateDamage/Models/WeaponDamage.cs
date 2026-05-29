namespace CalculateDamage.Models;

public class WeaponDamage {
    private readonly Random _random = new();
    protected int NumberOfRolls { get; init; }
    protected decimal MagicMultiplier { get; set; }
    protected decimal FlamingDamage { get; set; }
    public int Roll { get; private set; }
    public bool IsMagic { get; set; }
    public bool IsFlaming { get; set; }
    public int Damage { get; protected set; }

    protected void RollDices(int numberOfRolls) {
        if (numberOfRolls <= 0) return;

        Roll = 0;

        for (int i = 0; i < numberOfRolls; i++) {
            Roll += _random.Next(1, 7);
        }
    }

    public virtual void CalculateDamage() {
        throw new NotImplementedException();
    }
}
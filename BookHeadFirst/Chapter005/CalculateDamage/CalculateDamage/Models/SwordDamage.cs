namespace CalculateDamage.Models;

public class SwordDamage {
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;
    private readonly Random _random = new();
    private int _flamingDamage;
    private decimal _magicMultiplier = 1M;
    public int Roll { get; set; }
    public int Damage;

    public void CalculateDamage() {
        Damage = (int)(Roll * _magicMultiplier) + BaseDamage + _flamingDamage;
    }

    public void RollDices() {
        Roll = _random.Next(1, 7) + _random.Next(1, 7) + _random.Next(1, 7);
    }

    public void SetMagic(bool isMagic) {
        _magicMultiplier = isMagic ? 1.75M : 1M;
    }

    public void SetFlaming(bool isFlaming) {
        _flamingDamage = isFlaming ? FlameDamage : 0;
    }
}
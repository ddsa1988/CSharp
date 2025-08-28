namespace Examples.Models;

public class SwordDamage {
    public const int BaseDamage = 3;
    public const int FlameDamage = 2;

    public int Roll { get; set; }
    public decimal MagicMultiplier { get; set; } = 1M;
    public int FlamingDamage { get; set; }
    public int Damage { get; set; }

    public void CalculateDamage() {
        Damage = (int)(Roll * MagicMultiplier) + BaseDamage + FlamingDamage;
    }

    public void SetMagic(bool isMagic) {
        MagicMultiplier = isMagic ? 1.75M : 1M;
        CalculateDamage();
    }

    public void SetFlaming(bool isFlaming) {
        CalculateDamage();

        if (!isFlaming) return;

        Damage += FlameDamage;
    }
}
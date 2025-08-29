namespace SwordDamage.Models;

public class SwordDamage {
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;

    private decimal MagicMultiplier { get; set; } = 1M;
    private int FlamingDamage { get; set; }

    public int CalculateDamage(int roll, bool isMagic, bool isFlaming) {
        SetMagic(isMagic);
        SetFlaming(isFlaming);

        int damage = (int)(roll * MagicMultiplier) + BaseDamage + FlamingDamage;

        return damage;
    }

    private void SetMagic(bool isMagic) {
        MagicMultiplier = isMagic ? 1.75M : 1M;
    }

    private void SetFlaming(bool isFlaming) {
        FlamingDamage = isFlaming ? FlameDamage : 0;
    }
}
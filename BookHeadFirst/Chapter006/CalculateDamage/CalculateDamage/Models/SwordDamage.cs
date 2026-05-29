namespace CalculateDamage.Models;

public class SwordDamage : WeaponDamage {
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;

    public SwordDamage() {
        NumberOfRolls = 3;
    }

    public override void CalculateDamage() {
        RollDices(NumberOfRolls);

        MagicMultiplier = IsMagic ? 1.75M : 1M;
        FlamingDamage = IsFlaming ? FlameDamage : 0;

        Damage = (int)(Roll * MagicMultiplier + BaseDamage + FlamingDamage);
    }
}
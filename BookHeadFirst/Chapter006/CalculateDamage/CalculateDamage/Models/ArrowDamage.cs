namespace CalculateDamage.Models;

public class ArrowDamage : WeaponDamage {
    private const decimal BaseMultiplier = 0.35M;
    private const decimal FlameDamage = 1.25M;

    public ArrowDamage() {
        NumberOfRolls = 1;
    }

    public override void CalculateDamage() {
        RollDices(NumberOfRolls);

        MagicMultiplier = IsMagic ? 2.5M : 1M;
        FlamingDamage = IsFlaming ? FlameDamage : 0;

        Damage = (int)Math.Ceiling(Roll * MagicMultiplier * BaseMultiplier + FlamingDamage);
    }
}
namespace Examples.Models;

public class SwordDamage {
    private const int BaseDamage = 3;
    private const int FlameDamage = 2;
    private decimal _magicMultiplier;

    public int CalculateDamage(int roll, bool isMagic, bool isFlame) {
        _magicMultiplier = isMagic ? 1.75M : 1M;
        int damage = (int)(roll * _magicMultiplier) + BaseDamage;
        damage += isFlame ? FlameDamage : 0;

        return damage;
    }
}
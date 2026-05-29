using CalculateDamage.Models;

namespace CalculateDamage.Examples;

public static class UsingWeaponDamage {
    public static void Run() {
        char[] answers = ['0', '1', '2', '3'];

        while (true) {
            Console.Write("0 for sword damage, 1 for arrow damage, anything else to quit: ");
            char userInput = Console.ReadKey().KeyChar;

            WeaponDamage weaponDamage;

            switch (userInput) {
                case '0':
                    weaponDamage = new SwordDamage();
                    break;
                case '1':
                    weaponDamage = new ArrowDamage();
                    break;
                default:
                    return;
            }

            Console.Write("\n0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            userInput = Console.ReadKey().KeyChar;

            if (!answers.Contains(userInput)) return;

            bool isMagic = userInput == '1' || userInput == '3';
            bool isFlaming = userInput == '2' || userInput == '3';

            weaponDamage.IsMagic = isMagic;
            weaponDamage.IsFlaming = isFlaming;
            weaponDamage.CalculateDamage();

            Console.WriteLine($"\nRolled {weaponDamage.Roll} for {weaponDamage.Damage} HP\n");
        }
    }
}
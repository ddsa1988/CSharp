using CalculateDamage.Models;

namespace CalculateDamage.Examples;

public static class UsingSwordDamage {
    public static void Run() {
        char[] answers = ['0', '1', '2', '3'];
        var swordDamage = new SwordDamage();

        while (true) {
            Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            char userInput = Console.ReadKey().KeyChar;

            if (!answers.Contains(userInput)) return;

            bool isMagic = userInput == '1' || userInput == '3';
            bool isFlaming = userInput == '2' || userInput == '3';

            swordDamage.RollDices();
            swordDamage.SetMagic(isMagic);
            swordDamage.SetFlaming(isFlaming);

            swordDamage.CalculateDamage();
            Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
        }
    }
}
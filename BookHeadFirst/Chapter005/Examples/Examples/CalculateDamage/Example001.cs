using Examples.Models;

namespace Examples.CalculateDamage;

public static class Example001 {
    public static void Run() {
        const int numberDices = 3;
        const int diceMinValue = 1;
        const int diceMaxValue = 6;

        char[] options = ['0', '1', '2', '3'];
        var random = new Random();
        var swordDamage = new SwordDamage();

        while (true) {
            Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            char option = Console.ReadKey().KeyChar;

            if (!options.Contains(option)) break;

            int roll = 0;

            for (int i = 0; i < numberDices; i++) {
                roll += random.Next(diceMinValue, diceMaxValue + 1);
            }

            swordDamage.Roll = roll;
            swordDamage.SetMagic(option == '1' || option == '3');
            swordDamage.SetFlaming(option == '2' || option == '3');

            Console.WriteLine($"\n{nameof(roll)} {roll} for {swordDamage.Damage} HP");
        }
    }
}
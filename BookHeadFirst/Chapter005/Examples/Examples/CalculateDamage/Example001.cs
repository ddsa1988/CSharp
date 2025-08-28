namespace Examples.CalculateDamage;

public static class Example001 {
    public static void Run() {
        const int numberDices = 3;
        const int diceMinValue = 1;
        const int diceMaxValue = 6;

        char[] options = ['1', '2', '3'];
        var random = new Random();

        while (true) {
            Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
            string? input = Console.ReadLine();
            char option = input != null && input.Length > 0 ? input[0] : '\0';

            if (!options.Contains(option)) break;

            int rolled = 0;

            for (int i = 0; i < numberDices; i++) {
                rolled += random.Next(diceMinValue, diceMaxValue + 1);
            }

            Console.WriteLine($"{nameof(rolled)}: {rolled}");
        }
    }
}
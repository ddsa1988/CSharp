using GuessGame.Entities;

namespace GuessGame;

public class Program {
    public static void Main(string[] args) {
        const int minNumber = 0;
        const int maxNumber = 10;
        int randomNumber = MyRandom.GetNumber(minNumber, maxNumber);
        int chances = 3;
        bool isGameOver = false;

        while (!isGameOver) {
            Console.WriteLine($"You have {chances} chances to guess the correct number from {minNumber} to {maxNumber}.");

            Console.Write("Type your guess: ");
            string? input = Console.ReadLine();

            if (!ValidateNumber.IsNumberValid(input, minNumber, maxNumber, out int guess)) continue;

            if (guess < randomNumber) {
                Console.WriteLine("Your guess was too low!");
            } else if (guess > randomNumber) {
                Console.WriteLine("Your guess was to high!");
            } else {
                Console.WriteLine("Congratulations! You guessed the right number!");
                isGameOver = true;
                continue;
            }

            Console.WriteLine();

            chances--;

            if (chances != 0) continue;

            Console.WriteLine($"You've lost! The correct number was {randomNumber}.");
            isGameOver = true;
        }
    }
}
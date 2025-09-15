using Examples.Enums.Models;

namespace Examples.Enums;

public static class Example001 {
    public static void Run() {
        const int score = (int)TrickScore.Sit;
        Console.WriteLine($"{nameof(score)} => {score}");

        const TrickScore whichScore = (TrickScore)50;
        Console.WriteLine($"{nameof(whichScore)} => {whichScore}");

        Console.WriteLine(
            $"\"Sit\" == {nameof(TrickScore)}.{nameof(TrickScore.Sit)} => {"Sit" == nameof(TrickScore.Sit)}");
    }
}
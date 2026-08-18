namespace WorkingWithDecisions.Examples;

internal static class SwitchExpressions {
    internal static void Run() {
        Console.WriteLine(FromRainbow("Green"));
        Console.WriteLine(FromRainbow("black"));

        Console.WriteLine();

        Console.WriteLine(RockPaperScissors("Paper", "scissors"));
        Console.WriteLine(RockPaperScissors("rock", "water"));
    }

    // Switch expression
    private static string FromRainbow(string color) {
        return color.ToLower() switch {
            "red" => "#FF0000",
            "orange" => "#FF7F00",
            "yellow" => "#FFFF00",
            "green" => "#00FF00",
            "blue" => "#0000FF",
            "indigo" => "#4B0082",
            "violet" => "#9400D3",
            _ => "#FFFFFF", // Discard operator
        };
    }

    private static string RockPaperScissors(string first, string second) {
        // Switch expression with Tuples
        return (first.ToLower(), second.ToLower()) switch {
            ("rock", "paper") => "Paper wins.",
            ("rock", "scissors") => "Rock wins.",
            ("paper", "rock") => "Paper wins.",
            ("paper", "scissors") => "Scissors wins.",
            ("scissors", "rock") => "Rock wins.",
            ("scissors", "paper") => "Scissors wins.",
            (_, _) => "Tie.",
        };
    }
}
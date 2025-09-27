namespace Examples.AnonymousTypes;

public static class Example002 {
    public static void Run() {
        var players = new[] {
            new { Name = "Joe", YearsPlayed = 7, GlobarRank = 21 },
            new { Name = "Bob", YearsPlayed = 5, GlobarRank = 13 },
            new { Name = "Alice", YearsPlayed = 11, GlobarRank = 17 },
        };

        var playerWins = new[] {
            new { Name = "Joe", Round = 1, Winnings = 1.5M },
            new { Name = "Alice", Round = 2, Winnings = 2M },
            new { Name = "Bob", Round = 3, Winnings = .75M },
            new { Name = "Alice", Round = 4, Winnings = 1.3M },
            new { Name = "Alice", Round = 5, Winnings = .7M },
            new { Name = "Joe", Round = 6, Winnings = 1M },
        };

        var playerStats =
            from player in players
            join win in playerWins on player.Name equals win.Name
            orderby player.Name
            select new {
                player.Name,
                player.YearsPlayed,
                player.GlobarRank,
                win.Round,
                win.Winnings,
            };

        foreach (var playerStat in playerStats) {
            Console.WriteLine(playerStat);
        }
    }
}
namespace LanguageIntegratedQuery.Examples;

internal static class QueryOverString {
    public static void Run() {
        string[] currentVideoGames = ["Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"];

        {
            // LINQ query expression
            IEnumerable<string> subset =
                from game in currentVideoGames
                where game.Contains(' ')
                orderby game
                select game;

            foreach (string str in subset) {
                Console.WriteLine("Item = " + str);
            }

            Console.WriteLine();
        }

        {
            // LINQ method syntax
            IEnumerable<string> subset = currentVideoGames
                .Where(game => game.Contains(' '))
                .OrderBy(game => game, StringComparer.Ordinal)
                .Select(game => game);

            foreach (string str in subset) {
                Console.WriteLine("Item = " + str);
            }

            Console.WriteLine();
        }
    }
}
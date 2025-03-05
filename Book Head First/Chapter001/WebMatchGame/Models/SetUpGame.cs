namespace WebMatchGame.Models;

public static class SetUpGame {
    public static IEnumerable<string> GetRandomEmojis() {
        var random = new Random();

        IEnumerable<string> shuffledEmojis = Emoji.GetEmojis().OrderBy(item => random.Next());

        return shuffledEmojis;
    }
}
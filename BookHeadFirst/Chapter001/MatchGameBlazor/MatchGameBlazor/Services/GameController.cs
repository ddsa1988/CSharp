using MatchGameBlazor.Models;

namespace MatchGameBlazor.Services;

public class GameController {
    private const int NumberOfPairs = 8;
    public List<string> ShuffledEmojis = [];

    public GameController() {
        SetUpGame();
    }

    private void SetUpGame() {
        Random random = new();
        List<string> emojisPairs = Emojis.RandomEmojisPairs(NumberOfPairs);
        ShuffledEmojis = emojisPairs.OrderBy(item => random.Next()).ToList();
    }
}
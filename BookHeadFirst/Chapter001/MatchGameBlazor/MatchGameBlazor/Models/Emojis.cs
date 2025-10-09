namespace MatchGameBlazor.Models;

public static class Emojis {
    private static IEnumerable<string> AllEmojis => [
        "🐶", "🐺", "🐮", "🦊", "🐱", "🦁", "🐯", "🐹",
        "🌍", "🏜️", "🏟️", "🏔️", "🌋", "🏝️", "🤦‍♂️", "🏞️",
        "🎃", "🎇", "🎈", "🎎", "🎁", "🎄", "🧨", "⚽",
        "😎", "🥶", "🤬", "😈", "🤩", "💩", "🤡", "🤑"
    ];

    public static List<string> RandomEmojisPairs(int numberOfPairs) {
        Random random = new();
        List<string> allEmojis = new(AllEmojis);
        List<string> randomEmojis = [];

        for (int i = 0; i < numberOfPairs; i++) {
            int index = random.Next(allEmojis.Count);
            string emoji = allEmojis.ElementAt(index);
            allEmojis.RemoveAt(index);
            randomEmojis.AddRange([emoji, emoji]);
        }

        return randomEmojis;
    }
}
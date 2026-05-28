namespace Inheritance.Models;

public class Pigeon : Bird {
    public override Egg[] LayEggs(int numberOfEggs) {
        if (numberOfEggs <= 0) return Enumerable.Empty<Egg>().ToArray();

        const int minSize = 1;
        const int maxSize = 3;
        var eggs = new Egg[numberOfEggs];

        for (int i = 0; i < numberOfEggs; i++) {
            double eggSize = Random.NextDouble() * (maxSize - minSize) + minSize;
            eggs[i] = new Egg(eggSize, "white");
        }

        return eggs;
    }
}
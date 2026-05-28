namespace Inheritance.Models;

public class Ostrich : Bird {
    public override Egg[] LayEggs(int numberOfEggs) {
        if (numberOfEggs <= 0) return Enumerable.Empty<Egg>().ToArray();

        const int minSize = 12;
        const int maxSize = 13;
        var eggs = new Egg[numberOfEggs];

        for (int i = 0; i < numberOfEggs; i++) {
            double eggSize = Random.NextDouble() * (minSize - minSize) + minSize;
            eggs[i] = new Egg(eggSize, "speckled");
        }

        return eggs;
    }
}
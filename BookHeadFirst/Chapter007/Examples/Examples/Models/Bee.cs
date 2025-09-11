namespace Examples.Models;

public interface IWorker {
    public void DoWork();
}

public interface IDefender {
    public void Defend();
}

public abstract class Bee : IWorker {
    public abstract void DoWork();
    public abstract void Info();
}

public class NectarCollector : Bee {
    public override void DoWork() {
        Console.WriteLine("Nectar collector DoWork.");
    }

    public override void Info() {
        Console.WriteLine("Nectar collector Info.");
    }
}

public class HiveDefender : Bee, IDefender {
    public override void DoWork() {
        Console.WriteLine("Hive defender DoWork.");
    }

    public override void Info() {
        Console.WriteLine("Hive defender Info.");
    }

    public void Defend() {
        Console.WriteLine("Hive defender Defend.");
    }
}
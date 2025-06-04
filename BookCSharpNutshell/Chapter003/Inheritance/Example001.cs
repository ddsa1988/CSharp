namespace Chapter003.Inheritance;

public static class Example001 {
    public static void Run() {
        // A class can inherit from another class to extend or customize the original class.

        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };
        var house = new House() { Name = "House", Mortgage = 250000 };

        Console.WriteLine(stock);
        Console.WriteLine(house);
    }

    private class Asset {
        public string Name { get; set; } = string.Empty;

        public override string ToString() {
            return $"Asset [ Name = {Name} ]";
        }
    }

    private class Stock : Asset {
        public long SharesOwned { get; set; }

        public override string ToString() {
            return $"Stock [ Name = {Name}, SharesOwned = {SharesOwned} ]";
        }
    }

    private class House : Asset {
        public decimal Mortgage { get; set; }

        public override string ToString() {
            return $"House [ Name = {Name}, Mortgage = {Mortgage} ]";
        }
    }
}
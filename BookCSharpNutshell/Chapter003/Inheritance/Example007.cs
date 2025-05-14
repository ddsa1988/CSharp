namespace Chapter003.Inheritance;

public static class Example007 {
    public static void UserMain() {
        // The is operator tests whether a variable matches a pattern. 

        var asset = new Asset() { Name = "Asset" };
        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };

        Console.WriteLine("{0} is {1} => {2}", nameof(asset), nameof(Asset), asset is Asset);
        Console.WriteLine("{0} is {1} => {2}", nameof(asset), nameof(Stock), asset is Stock);
        Console.WriteLine("{0} is {1} => {2}", nameof(asset), nameof(House), asset is House);

        Console.WriteLine();

        Console.WriteLine("{0} is {1} => {2}", nameof(stock), nameof(Asset), stock is Asset);
        Console.WriteLine("{0} is {1} => {2}", nameof(stock), nameof(Stock), stock is Stock);
        Console.WriteLine("{0} is {1} => {2}", nameof(stock), nameof(House), stock is House);
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
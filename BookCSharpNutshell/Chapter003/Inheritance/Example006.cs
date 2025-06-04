namespace Chapter003.Inheritance;

public static class Example006 {
    public static void Run() {
        // The as operator performs a downcast that evaluates to null (rather than throwing an exception) if the downcast fail

        var asset = new Asset() { Name = "Asset" };
        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };

        Console.WriteLine("{0} => {1}", nameof(asset), asset);
        Console.WriteLine("{0} => {1}", nameof(stock), stock);

        stock = asset as Stock;
        Console.WriteLine("{0} => {1}", nameof(stock), stock == null ? "null" : stock);
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
}
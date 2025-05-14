namespace Chapter003.Inheritance;

public static class Example008 {
    public static void UserMain() {
        // A function marked as virtual can be overridden by subclasses wanting to provide a specialized implementation.
        // Methods, properties, indexers, and events can all be declared virtual

        var asset = new Asset() { Name = "Asset" };
        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };

        Console.WriteLine("{0} => {1} : {2}", nameof(asset), nameof(asset.Liability), asset.Liability());
        Console.WriteLine("{0} => {1} : {2}", nameof(stock), nameof(stock.Liability), stock.Liability());
    }

    private class Asset {
        public string Name { get; set; } = string.Empty;

        public virtual decimal Liability() {
            return 0;
        }

        public override string ToString() {
            return $"Asset [ Name = {Name} ]";
        }
    }

    private class Stock : Asset {
        public long SharesOwned { get; set; }

        public override decimal Liability() {
            return SharesOwned;
        }

        public override string ToString() {
            return $"Stock [ Name = {Name}, SharesOwned = {SharesOwned} ]";
        }
    }
}
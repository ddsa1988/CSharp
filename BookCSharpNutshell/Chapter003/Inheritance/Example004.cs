namespace Chapter003.Inheritance;

public static class Example004 {
    public static void Run() {
        // A downcast operation creates a subclass reference from a base class reference

        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };

        Console.WriteLine("{0} => {1}", nameof(stock), stock);

        Asset asset = stock;
        stock = (Stock)asset;

        Console.WriteLine("{0} => {1}", nameof(asset), asset);
        //Console.WriteLine("{0} => {1}", nameof(asset), asset.SharesOwned); // Compile-time error

        Console.WriteLine("{0} => {1}", nameof(stock), stock);
        Console.WriteLine("{0} => {1}", nameof(stock), stock.SharesOwned);
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
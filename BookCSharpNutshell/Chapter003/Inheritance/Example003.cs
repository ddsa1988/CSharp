namespace Chapter003.Inheritance;

public static class Example003 {
    public static void UserMain() {
        // An upcast operation creates a base class reference from a subclass reference

        var asset = new Asset() { Name = "Asset" };
        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };

        Console.WriteLine("{0} => {1}", nameof(asset), asset);
        Console.WriteLine("{0} => {1}", nameof(stock), stock);

        asset = stock;

        Console.WriteLine("{0} => {1}", nameof(asset), asset);
        Console.WriteLine("{0} => {1}", nameof(asset), asset.Name);
        // Console.WriteLine("{0} => {1}", nameof(asset), asset.SharesOwned); // Compile-time error
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
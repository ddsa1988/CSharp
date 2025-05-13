namespace Chapter003.Inheritance;

public static class Example005 {
    public static void UserMain() {
        // A downcast operation creates a subclass reference from a base class reference

        var asset = new Asset() { Name = "Asset" };
        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };

        Console.WriteLine("{0} => {1}", nameof(asset), asset);
        Console.WriteLine("{0} => {1}", nameof(stock), stock);

        try {
            stock = (Stock)asset;
        } catch (InvalidCastException ex) {
            Console.WriteLine("{0} => {1}", nameof(ex), ex.Message);
        }
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
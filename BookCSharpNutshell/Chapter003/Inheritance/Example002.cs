namespace Chapter003.Inheritance;

public static class Example002 {
    public static void Run() {
        // References are polymorphic. This means a variable of type x can refer to an object that subclasses x. 

        var asset = new Asset() { Name = "Asset" };
        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };
        var house = new House() { Name = "House", Mortgage = 250000 };

        Display(asset);
        Display(house);
        Display(stock);
    }

    private static void Display(Asset asset) {
        Console.WriteLine("{0} = {1}", nameof(asset.Name), asset.Name);
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
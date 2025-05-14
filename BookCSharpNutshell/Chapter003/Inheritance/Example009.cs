namespace Chapter003.Inheritance;

public static class Example009 {
    public static void UserMain() {
        // A class declared as abstract can never be instantiated. Instead, only its concrete
        // subclasses can be instantiated.

        // Asset asset = new Asset(); // Compile-time error
        var stock = new Stock() { SharesOwned = 1000, CurrentPrice = 20 };

        Console.WriteLine(stock.Greeting("Tuesday"));
        Console.WriteLine();
    }

    private abstract class Asset {
        public abstract long SharesOwned { get; set; }
        public abstract decimal NetValue();

        public virtual string Greeting(string msg) {
            return $"Hello => {msg}, {SharesOwned}";
        }
    }

    private class Stock : Asset {
        public override long SharesOwned { get; set; }
        public decimal CurrentPrice { get; set; }

        public override decimal NetValue() {
            return SharesOwned * CurrentPrice;
        }
    }
}
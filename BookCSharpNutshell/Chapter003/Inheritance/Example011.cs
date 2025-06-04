namespace Chapter003.Inheritance;

public static class Example011 {
    public static void Run() {
        // The "base" keyword access the members from the base class

        var stock = new Stock() { Name = "Stock", SharesOwned = 1000 };
        stock.Test();
    }

    private class Asset {
        public string Name { get; set; } = string.Empty;

        public virtual void Test() {
            Console.WriteLine("Your are inside the base class method.");
        }

        public override string ToString() {
            return $"Asset [ Name = {Name} ]";
        }
    }

    private class Stock : Asset {
        public long SharesOwned { get; set; }

        public override void Test() {
            Console.WriteLine("Your are inside the derived class method.");
            base.Test();
        }

        public override string ToString() {
            return $"Stock [ Name = {Name}, SharesOwned = {SharesOwned} ]";
        }
    }
}
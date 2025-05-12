namespace Chapter003.Inheritance;

public static class Example002 {
    public static void UserMain() {
        // References are polymorphic. This means a variable of type x can refer to an object that subclasses x. 
    }

    private class Asset {
        public string Name { get; set; } = string.Empty;
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
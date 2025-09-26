namespace Examples.LinqTest;

public static class Example008 {
    public static void Run() {
        List<PrintWhenGetting> objects = [];

        for (int i = 1; i < 5; i++) {
            objects.Add(new PrintWhenGetting() { InstanceNumber = i });
        }

        Console.WriteLine("Set up the query");

        IEnumerable<int> result =
            from obj in objects
            select obj.InstanceNumber;

        Console.WriteLine("Run the foreach");

        foreach (int obj in result) {
            Console.WriteLine($"Writing #{obj}");
        }
    }

    private class PrintWhenGetting {
        private readonly int _instanceNumber;

        public int InstanceNumber {
            get {
                Console.WriteLine($"Getting #{_instanceNumber}");
                return _instanceNumber;
            }
            init => _instanceNumber = value;
        }
    }
}
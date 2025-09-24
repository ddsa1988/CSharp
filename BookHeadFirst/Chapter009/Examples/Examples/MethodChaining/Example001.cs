namespace Examples.MethodChaining;

public static class Example001 {
    public static void Run() {
        var a = new AddSubtract() { Value = 5 };

        AddSubtract result = a.Add(5).Subtract(3).Add(9).Subtract(12);

        Console.WriteLine($"\n{nameof(result.Value)} => {result.Value}");
    }

    private class AddSubtract {
        public int Value { get; init; }

        public AddSubtract Add(int value) {
            Console.WriteLine($"Value: {Value}, adding {value}");
            return new AddSubtract() { Value = Value + value };
        }

        public AddSubtract Subtract(int value) {
            Console.WriteLine($"Value: {Value}, subtracting {value}");
            return new AddSubtract() { Value = Value - value };
        }
    }
}
namespace TypeConversions.Examples;

internal static class UsingCheckedKeyword {
    internal static void Run() {
        const byte b1 = 100;
        const byte b2 = 250;

        {
            byte sum = (byte)Add(b1, b2);
            Console.WriteLine($"Byte: {b1} + {b2} = {sum}");
        }

        Console.WriteLine();

        {
            try {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine($"Byte: {b1} + {b2} = {sum}");
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine();

        {
            try {
                checked {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine($"Byte: {b1} + {b2} = {sum}");
                }
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static int Add(int x, int y) => x + y;
}
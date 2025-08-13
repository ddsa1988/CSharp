namespace Examples.Loops;

public static class Example002 {
    public static void Run() {
        Ex001();
        Ex002();
        Ex003();
        Ex004();
    }

    private static void Ex001() {
        int count = 5;

        while (count > 0) {
            count *= 3;
            Console.Write(count + " ");

            count *= -1;
            Console.Write(count + "\n");
        }
    }

    private static void Ex002() {
        for (int i = 1; i < 100; i *= 2) {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    private static void Ex003() {
        int j = 2;
        j -= 1;

        while (j < 25) {
            Console.Write(j + " ");
            j += 5;
        }

        Console.WriteLine();
    }

    private static void Ex004() {
        int p = 2;

        for (int q = 2; q < 32; q *= 2) {
            while (p < q) {
                p *= 2;
                // Console.Write(p + " ");
            }

            q = p - q;
            // Console.Write(q + " ");
        }

        Console.WriteLine();
    }
}
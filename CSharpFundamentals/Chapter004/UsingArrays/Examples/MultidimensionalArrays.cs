namespace UsingArrays.Examples;

internal static class MultidimensionalArrays {
    internal static void Run() {
        RectangularArray();

        Console.WriteLine();

        JaggedArray();
    }

    private static void RectangularArray() {
        Console.WriteLine("=> Rectangular multidimensional array:\n");

        int[,] matrix = new int[3, 4];

        for (int row = 0; row < matrix.GetLength(0); row++) {
            for (int col = 0; col < matrix.GetLength(1); col++) {
                matrix[row, col] = row * col;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++) {
            for (int col = 0; col < matrix.GetLength(1); col++) {
                Console.Write($"[{matrix[row, col]}] ");
            }

            Console.WriteLine();
        }
    }

    private static void JaggedArray() {
        Console.WriteLine("=> Jagged multidimensional array:\n");

        int[][] jaggedArray = new int[5][];

        for (int i = 0; i < jaggedArray.Length; i++) {
            jaggedArray[i] = new int[i + 1];
        }

        foreach (int[] array in jaggedArray) {
            foreach (int value in array) {
                Console.Write($"[{value}] ");
            }

            Console.WriteLine();
        }
    }
}
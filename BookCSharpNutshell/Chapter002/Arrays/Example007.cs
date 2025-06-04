namespace Chapter002.Arrays;

public static class Example007 {
    public static void Run() {
        // Jagged arrays [array of arrays] are declared using successive square brackets to represent each dimension.
        // The inner dimensions aren’t specified in the declaration because, unlike a rectangular array,
        // each inner array can be an arbitrary length. Each inner array is implicitly initialized to
        // null rather than an empty array.

        int[][] matrix = new int[3][];

        PrintMatrix(matrix);
        Console.WriteLine();

        for (int i = 0; i < matrix.Length; i++) {
            matrix[i] = new int[(i + 1) * 2];
        }

        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[][] matrix) {
        int firstDimLength = matrix.Length;

        for (int row = 0; row < firstDimLength; row++) {
            if (matrix[row] == null) {
                Console.WriteLine("NULL");
                continue;
            }

            int secondDimLength = matrix[row].Length;
            for (int column = 0; column < secondDimLength; column++) {
                Console.Write(matrix[row][column] + " ");
            }

            Console.WriteLine();
        }
    }
}
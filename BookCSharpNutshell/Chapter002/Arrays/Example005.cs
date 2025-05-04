namespace Chapter002.Arrays;

public static class Example005 {
    public static void UserMain() {
        // Rectangular arrays are declared using commas to separate each dimension.
        // Rectangular arrays have fixed length in each inner dimension.

        int[,] matrix = new int[3, 3];
        int firstDimLength = matrix.GetLength(0);
        int secondDimLength = matrix.GetLength(1);

        PrintMatrix(matrix);
        Console.WriteLine();

        for (int i = 0; i < firstDimLength; i++) {
            for (int j = 0; j < secondDimLength; j++) {
                matrix[i, j] = i * 3 + j;
            }
        }

        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix) {
        int firstDimLength = matrix.GetLength(0);
        int secondDimLength = matrix.GetLength(1);

        for (int row = 0; row < firstDimLength; row++) {
            for (int column = 0; column < secondDimLength; column++) {
                Console.Write(matrix[row, column] + " ");
            }

            Console.WriteLine();
        }
    }
}
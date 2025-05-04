namespace Chapter002.Arrays;

public static class Example006 {
    public static void UserMain() {
        // You can initialize a rectangular array with explicit values

        int[,] matrix = new int[,] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

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
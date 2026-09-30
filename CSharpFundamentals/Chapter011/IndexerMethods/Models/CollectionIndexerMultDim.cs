using System.Collections;

namespace IndexerMethods.Models;

internal class CollectionIndexerMultDim {
    private readonly int[][] _my2DintArray = new int[2][];

    public CollectionIndexerMultDim() {
        for (int i = 0; i < _my2DintArray.Length; i++) {
            _my2DintArray[i] = new int[(i + 1) * 2];
        }
    }

    public int this[int row, int col] {
        get => _my2DintArray[row][col];
        set => _my2DintArray[row][col] = value;
    }

    public int Count => _my2DintArray.Length;

    public void Print() {
        foreach (int[] row in _my2DintArray) {
            foreach (int col in row) {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
    }
}
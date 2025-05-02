namespace Chapter002.Arrays;

public static class Example002 {
    public static void UserMain() {
        // Default element initialization

        {
            var points = new PointStruct[5];
            int a = points[4].X;

            Console.WriteLine("{0} = {1}", nameof(a), a);
        }

        Console.WriteLine();

        {
            var points = new PointClass[5]; // Allocate PointClass references
            int a;

            try {
                a = points[4].X;
                Console.WriteLine("{0} = {1}", nameof(a), a);
            } catch (NullReferenceException e) {
                Console.WriteLine("Array not initialized: " + e.Message);
            }

            for (int i = 0; i < points.Length; i++) {
                points[i] = new PointClass(); // Instantiate PointClass
            }

            a = points[4].X;
            Console.WriteLine("{0} = {1}", nameof(a), a);
        }
    }
}

internal struct PointStruct {
    public int X;
    public int Y;
}

internal class PointClass {
    public int X;
    public int Y;
}
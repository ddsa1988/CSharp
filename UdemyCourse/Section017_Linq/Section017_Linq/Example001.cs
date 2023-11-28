namespace Section017_Linq;

public class Example001 {
    public static void CallMain() {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

        foreach (int value in result) {
            Console.Write(value + " ");
        }
    }
}
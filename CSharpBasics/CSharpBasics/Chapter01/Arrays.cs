using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpBasics.Chapter01;

public class Arrays {
    public static void MyMain() {
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            int[] intNumbers = new int[] { 1, 2, 3, 4, 5 };
            float[] floatNumbers = new float[5];

            PrintCollection(vowels);
            PrintCollection(intNumbers);
            PrintCollection(floatNumbers);
        }
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        StringBuilder sb = new StringBuilder();

        sb.Append("[ ");

        foreach (T element in collection) {
            sb.Append(element + " ");
        }

        sb.Append(']');

        Console.WriteLine(sb.ToString());
    }
}
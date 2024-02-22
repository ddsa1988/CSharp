using System.Text;

namespace CSharpBasics.Chapter01;

public class Arrays {
    public static void MyMain() {
        {
            // char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            // int[] intNumbers = new int[] { 1, 2, 3, 4, 5 };
            // float[] floatNumbers = new float[5];
            int[,] rectangularArray = new int[3, 4]; //Represent n-dimensional block of memory
            int[][] jaggedArray = new int[3][]; //Array of arrays

            // Person[] people = new Person[5];
            //
            // Index first = 0;
            // Index last = ^1;
            // Index secondLast = ^2;

            // PrintCollection(vowels);
            // PrintCollection(intNumbers);
            // PrintCollection(floatNumbers);
            // PrintCollection(people);
            //
            // Console.WriteLine(vowels[first]);
            // Console.WriteLine(vowels[last]);
            // Console.WriteLine(vowels[secondLast]);
            //
            // Console.WriteLine(vowels[..2]);
            // Console.WriteLine(vowels[2..]);
            // Console.WriteLine(vowels[2..3]);

            // Console.WriteLine(rectangularMatrix.GetLength(0));
            // Console.WriteLine(rectangularMatrix.GetLength(1));

            Console.WriteLine("Rectangular array:");

            for (int i = 0; i < rectangularArray.GetLength(0); i++) {
                for (int j = 0; j < rectangularArray.GetLength(1); j++) {
                    rectangularArray[i, j] = i * 3 + j;
                    Console.Write($"{rectangularArray[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nJagged array:");

            for (int i = 0; i < jaggedArray.Length; i++) {
                jaggedArray[i] = new int[i + 3];

                for (int j = 0; j < jaggedArray[i].Length; j++) {
                    jaggedArray[i][j] = i * 3 + j;
                    Console.Write($"{jaggedArray[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }

    private class Person {
        public string Name { get; set; }

        public Person(string name) {
            Name = name;
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
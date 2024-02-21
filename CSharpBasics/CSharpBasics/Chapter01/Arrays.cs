using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace CSharpBasics.Chapter01;

public class Arrays {
    public static void MyMain() {
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            int[] intNumbers = new int[] { 1, 2, 3, 4, 5 };
            float[] floatNumbers = new float[5];
            Person[] people = new Person[5];

            Index first = 0;
            Index last = ^1;
            Index secondLast = ^2;

            PrintCollection(vowels);
            PrintCollection(intNumbers);
            PrintCollection(floatNumbers);
            PrintCollection(people);

            Console.WriteLine(vowels[first]);
            Console.WriteLine(vowels[last]);
            Console.WriteLine(vowels[secondLast]);

            Console.WriteLine(vowels[..2]);
            Console.WriteLine(vowels[2..]);
            Console.WriteLine(vowels[2..3]);
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
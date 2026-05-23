using WorkingWithArrays.Models;

namespace WorkingWithArrays.Examples;

public static class ArrayOfReferenceTypes2 {
    public static void Run() {
        var people = new Person[10];

        Console.WriteLine(people.Length);

        foreach (Person person in people) {
            Console.Write((person == null ? "null" : person.ToString()) + ", ");
        }

        for (int i = 0; i < people.Length; i++) {
            people[i] = new Person() { Name = $"Person {i + 1}" };
        }

        Console.WriteLine();

        foreach (Person person in people) {
            Console.Write((person == null ? "null" : person.ToString()) + ", ");
        }
    }
}
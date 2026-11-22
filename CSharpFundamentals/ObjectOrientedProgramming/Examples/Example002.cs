using ObjectOrientedProgramming.Models.People;

namespace ObjectOrientedProgramming.Examples;

internal static class Example002 {
    public static void Run() {
        Person[] people = [
            new Person("diego alexander", new DateOnly(1988, 1, 22)),
            new Student("Amanda perna", new DateOnly(1993, 10, 16), "Software Engineering"),
            new Student("Eduarda", new DateOnly(2026, 6, 1), "Baby"),
            new Person("amora", new DateOnly(2022, 12, 22))
        ];

        foreach (Person person in people) {
            Console.WriteLine(person);

            if (person is not Student student) continue;

            Console.WriteLine(student.Course);
        }
    }
}
namespace Examples.Inheritance;

public static class Example004 {
    public static void Run() {
        var person = new Person("Amanda", "Perna");
        var student = new Student("Diego", "Alexander", 15);

        Console.WriteLine(person);
        Console.WriteLine(student);
    }

    private class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() {
            return $"Person [FirstName = {FirstName}, LastName = {LastName}]";
        }
    }

    private class Student : Person {
        public int Id { get; set; }

        public Student(string firstName, string lastName, int id) : base(firstName, lastName) {
            Id = id;
        }

        public override string ToString() {
            return $"Student [FirstName = {FirstName}, LastName = {LastName}, Id = {Id}]";
        }
    }
}
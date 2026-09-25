namespace ObservableCollections.Models;

internal class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public Person(string firstName, string lastName, int age) {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString() =>
        $"Person {{ {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Age)} {Age} }}";
}
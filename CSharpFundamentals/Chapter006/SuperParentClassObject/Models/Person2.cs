namespace SuperParentClassObject.Models;

internal class Person2 {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person2(string firstName, string lastName, int age) {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override int GetHashCode() {
        return ToString().GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj is not Person2 other) return false;

        if (ReferenceEquals(this, other)) return true;

        return FirstName == other.FirstName && LastName == other.LastName && Age == other.Age;
    }

    // public override bool Equals(object? obj) {
    //     return obj?.ToString() == ToString();
    // }

    public override string ToString() {
        return $"Person2 {{ First Name: {FirstName}, LastName: {LastName}, Age: {Age} }}";
    }
}
namespace Chapter004.Records;

public static class Example003 {
    public static void Run() {
        // You can define your own copy constructor.

        var p1 = new Person("John", "Doe") { PhoneNumbers = ["123"] };
        Person p2 = p1 with { FirstName = "Jane", PhoneNumbers = ["456"] };

        p1.PhoneNumbers.Add("456");
        p2.PhoneNumbers.Add("985");

        Console.WriteLine("{0} => {1}", nameof(p1), p1);
        Console.WriteLine("{0} => {1}", nameof(p2), p2);
    }

    private record Person(string FirstName, string LastName) {
        public List<string>? PhoneNumbers { get; init; }

        protected Person(Person other) {
            FirstName = other.FirstName;
            LastName = other.LastName;

            if (other.PhoneNumbers != null) {
                PhoneNumbers = other.PhoneNumbers;
            }
        }

        public override string ToString() {
            return
                "Person [FirstName = " + FirstName + ", " +
                "LastName = " + LastName + ", " +
                "PhoneNumbers = " + string.Join(", ", PhoneNumbers ?? Enumerable.Empty<string>().ToList());
        }
    }
}
namespace Chapter003.Classes;

public static class Example005 {
    public static void Run() {
        // The "this" reference refers to the instance itself.
        // The "this" reference is valid only within nonstatic members of a class or struct.

        var p1 = new Person("Diego");
        var p2 = new Person("Amanda");

        Console.WriteLine("{0} => {1}", nameof(p1), p1);
        Console.WriteLine("{0} => {1}\n", nameof(p2), p2);

        p1.Marry(p2);

        Console.WriteLine("{0} => {1}", nameof(p1), p1);
        Console.WriteLine("{0} => {1}", nameof(p2), p2);
    }

    private class Person {
        public string Name { get; }
        public Person? Partner { get; private set; }

        public Person(Person person) : this(person.Name) { }

        public Person(string name) {
            Name = name;
        }

        public void Marry(Person? partner) {
            if (partner == null) return;
            if (object.Equals(Name, partner.Name)) return;

            Partner = new Person(partner);
            partner.Partner = new Person(this);
        }

        public override string ToString() {
            string partnerName = Partner == null ? "Without partner" : Partner.Name;

            // return "Person { Name = " + Name + ", Partner = " + Partner + " }";
            return "Person { Name = " + Name + ", Partner = " + partnerName + " }";
        }
    }
}
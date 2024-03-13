namespace CSharpBasics.Chapter02;

public class Classes {
    public static void MyMain() {
        Person p1 = new Person("Diego", 32);
        Person p2 = new Person() { Name = "Amanda", Age = 30 };
        Person p3 = new Person("Rodrigo", 33, 10);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        Console.WriteLine("Instance counter: " + Person.GetCounter());
    }

    public class Person {
        private static int counter = 0; //Static field
        private readonly int number; //Read-only field can be assigned only in its declaration or in the constructor
        public const float Pi = 3.14F; //A constant field must be initialized with a value
        public string Name { get; set; } = string.Empty; //Property contain get and set accessors
        public int Age { get; set; } //Property

        public Person() {
            counter++;
        }

        public Person(string name, int age) : this() {
            //Constructor overload. The this keyword calls the parameterless constructor
            Name = name;
            Age = age;
        }

        public Person(string name, int age, int number) : this(name, age) {
            //Constructor overload. The this keyword calls the constructor with the parameters 'name and age'
            this.number = number;
        }

        public static int GetCounter() {
            return counter;
        }

        public override string ToString() {
            return "Name: " + Name +
                   " Age: " + Age +
                   " Number " + number;
        }
    }
}
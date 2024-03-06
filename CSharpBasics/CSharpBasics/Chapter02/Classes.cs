using System.Reflection.PortableExecutable;

namespace CSharpBasics.Chapter02;

public class Classes {
    public static void MyMain() {
        Person p1 = new Person("Diego", 32);
        Person p2 = new Person("Amanda", 30, 200);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }

    public class Person {
        private string name;
        private int age;
        private readonly int number; //Read-only can be assigned only in its declaration or in the constructor
        public const float Pi = 3.14F;

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, int number) : this(name, age) {
            //Constructor overload. The this keyword calls another constructor
            this.number = number;
        }

        public override string ToString() {
            return "Name: " + name +
                   " Age: " + age +
                   " Number " + number;
        }
    }
}
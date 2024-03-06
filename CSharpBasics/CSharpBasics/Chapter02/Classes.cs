using System.Reflection.PortableExecutable;

namespace CSharpBasics.Chapter02;

public class Classes {
    public static void MyMain() {
        Console.WriteLine("Test");
    }

    public class MyClass {
        private string name;
        private int age;
        private readonly int number; //Read-only can be assigned only in its declaration or in the constructor
        public const float Pi = 3.14F;

        public MyClass(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public MyClass(string name, int age, int number) : this(name, age) { //Constructor overload
            this.number = number;
        }
    }
}
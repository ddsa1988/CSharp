namespace Section015_Generics;

public class Program {
    public static void Main(string[] args) {

        {
            UserStack<int> numbers = new UserStack<int>();
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            Console.WriteLine(numbers);
            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers);
            Console.WriteLine(numbers.Peek());
            Console.WriteLine();
        }
        
        {
            UserStack<string> names = new UserStack<string>();
            names.Push("Diego");
            names.Push("Amanda");
            names.Push("Joao");

            Console.WriteLine(names);
            Console.WriteLine(names.Pop());
            Console.WriteLine(names);
            Console.WriteLine(names.Peek());
        }
    }
}

namespace CSharpBasics.Chapter01;

public class FirstProgram {
    public static void MyMain() {
        
        Console.WriteLine(FeetToInches(30));
        Console.WriteLine(FeetToInches(100));
        return;
        
        int FeetToInches(int feet) {
            int inches = feet * 12;
            return inches;
        }
    }
}
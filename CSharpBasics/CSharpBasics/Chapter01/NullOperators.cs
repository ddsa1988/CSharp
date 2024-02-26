namespace CSharpBasics.Chapter01;

public class NullOperators {
    public static void MyMain() {
        //Null-Coalescing Operator: if the left operand is null the right operand i assigned
        {
            string? s1 = null;
            string s2 = s1 ?? "Diego";
            string s3 = "Amanda" ?? "Diego";

            Console.WriteLine($"s1 = {s1}, s2 = {s2}, s3 = {s3}");
        }
        {
            string? s1 = null;
            string s2 = s1 != null ? s1 : "Diego";

            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
        }

        Console.WriteLine();
        
        //Null-Coalescing Assignment Operator
        {
            string? s1 = null;
            string? s2 = "Diego";
            s1 ??= "Amanda";
            s2 ??= "Amanda";

            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
        }
        {
            string? s1 = null;
            string? s2 = "Diego";
            s1 = s1 != null ? s1 : "Amanda";
            s2 = s2 != null ? s2 : "Amanda";

            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
        }
        Console.WriteLine();
        
        //Null-Conditional Operator
        {
            string? s1 = null;

            // Console.WriteLine(s1.Length); Exception: System.NullReferenceException
            Console.WriteLine(s1?.Length);
        }
        {
            string? s1 = null;
            // int length = s1?.Length; Illegal: int can't be bull
            int? length = s1?.Length; //int? can be null
            Console.WriteLine(length);
        }
    }
}
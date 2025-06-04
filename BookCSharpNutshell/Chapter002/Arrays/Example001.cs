namespace Chapter002.Arrays;

public static class Example001 {
    public static void Run() {
        // An array represents a fixed number of variables (called elements) of a particular type.
        // The elements in an array are always stored in a contiguous block of memory providing highly efficient access.

        {
            char[] vowels = new char[5]; // Declare an array of 5 characters

            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            for (int i = 0; i < vowels.Length; i++) {
                Console.Write(vowels[i]);
            }
        }

        Console.WriteLine();

        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; // Array initialization expression 

            foreach (char t in vowels) {
                Console.Write(t);
            }
        }

        Console.WriteLine();

        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u']; // Array collection expression

            Console.WriteLine(string.Join("", vowels));
        }
    }
}
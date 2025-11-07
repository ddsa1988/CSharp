namespace Examples.Nullable;

public static class Example001 {
    // Nullable value type
    public static void Run() {
        Console.Write("Type 'y' or 'n': ");
        char choice = char.ToLower(Console.ReadKey(true).KeyChar);

        bool? optionalYesOrNo = choice switch {
            'y' => true,
            'n' => false,
            _ => null
        };

        string msg = optionalYesOrNo.HasValue
            ? $"{nameof(optionalYesOrNo)}: {optionalYesOrNo.Value}"
            : $"{nameof(optionalYesOrNo)}: null";

        Console.WriteLine(Environment.NewLine + msg);
    }
}
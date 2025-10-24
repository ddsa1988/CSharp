using System.Text.Json;

namespace Examples.JsonSerialization;

public static class Example004 {
    public static void Run() {
        Console.WriteLine(JsonSerializer.Serialize(3));
        Console.WriteLine(JsonSerializer.Serialize((long)-3));
        Console.WriteLine(JsonSerializer.Serialize((byte)0));
        Console.WriteLine(JsonSerializer.Serialize(float.MaxValue));
        Console.WriteLine(JsonSerializer.Serialize(float.MinValue));
        Console.WriteLine(JsonSerializer.Serialize(true));
        Console.WriteLine(JsonSerializer.Serialize("Elephant"));
        Console.WriteLine(JsonSerializer.Serialize("Elephant".ToCharArray()));
        Console.WriteLine(JsonSerializer.Serialize("🐘"));
    }
}
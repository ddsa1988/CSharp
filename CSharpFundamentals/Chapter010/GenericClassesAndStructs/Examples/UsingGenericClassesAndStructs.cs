using GenericClassesAndStructs.Models;

namespace GenericClassesAndStructs.Examples;

public static class UsingGenericClassesAndStructs {
    public static void Run() {
        var pointStruct = new PointStruct<int>(10, 20);
        var pointClass = new PointClass<float>(25.7f, 30f);

        Console.WriteLine(pointStruct);
        Console.WriteLine(pointClass);
    }
}
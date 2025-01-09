namespace Basics.S004_Arrays;

public static class ArrayOfObjects {
    public static void UserMain() {
        object[] objects = [10, false, new DateOnly(1988, 1, 22), "Form and void", new[] { 0, 1, 2, 3 }];

        foreach (object obj in objects) Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
}
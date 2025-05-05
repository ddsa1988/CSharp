using System.Text;

namespace Chapter002.Parameters;

public static class Example003 {
    public static void UserMain() {
        // Passing a reference-type argument by value copies the reference but not the object.

        var sb = new StringBuilder("Diego");
        Console.WriteLine("Before method: {0} = {1}", nameof(sb), sb);

        Foo(sb);

        Console.WriteLine("After method: {0} = {1}", nameof(sb), sb);
    }

    private static void Foo(StringBuilder fooSb) {
        Console.WriteLine("Inside method before append value: {0} = {1}", nameof(fooSb), fooSb);

        fooSb.Append(" Alexandre");
        Console.WriteLine("Inside method after append value: {0} = {1}", nameof(fooSb), fooSb);

        fooSb = new StringBuilder("Amanda");
        Console.WriteLine("Inside method after new instantiation: {0} = {1}", nameof(fooSb), fooSb);
    }
}
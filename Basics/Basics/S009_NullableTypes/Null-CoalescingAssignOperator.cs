namespace Basics.S009_NullableTypes;

public static class NullCoalescingAssignOperator {
    public static void UserMain() {
        int? intValue = null;

        intValue ??= 100;
        intValue ??= 200;

        Console.WriteLine(intValue);
    }
}
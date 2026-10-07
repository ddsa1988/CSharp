using Delegates.Models;

namespace Delegates.Examples;

internal static class SimpleDelegate {
    public static void Run() {
        // Creates a delegate object that "points" to "SimpleMath.Add
        var binaryOp = new BinaryOp(SimpleMath.Add);

        Console.WriteLine(binaryOp(10, 20));
        Console.WriteLine();

        DisplayDelegateInfo(binaryOp);
    }

    private static void DisplayDelegateInfo(Delegate delegateObj) {
        foreach (Delegate d in delegateObj.GetInvocationList()) {
            Console.WriteLine("Method name => " + d.Method);
            Console.WriteLine("Type name => " + d.Target);
        }
    }
}
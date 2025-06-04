namespace Chapter004.LambdaExpressions;

public static class Example006 {
    public static void Run() {
        // Capturing iteration variables

        const int size = 3;
        var actions = new Action[size];

        for (int i = 0; i < size; i++) {
            int loopScopedI = i;

            actions[i] = () => Console.Write(loopScopedI);
        }

        foreach (Action action in actions) {
            action();
        }
    }
}
namespace Chapter004.Delegates;

public static class Example003 {
    public static void Run() {
        /*
            When an instance method is assigned to a delegate object, the latter maintains a
            reference not only to the method but also to the instance to which the method belongs.
            The System.Delegate class’s Target property represents this instance (and will be null
            for a delegate referencing a static method).
            Because the instance is stored in the delegate’s Target property, its lifetime is extended
            to the delegate’s lifetime.
         */

        var report = new MyReport() { Prefix = "%Completed: " };
        ProgressReporter progress = report.ReportProgress;

        progress(99);

        Console.WriteLine("{0} == {1} => {2}", nameof(progress.Target), nameof(report), progress.Target == report);
        Console.WriteLine("{0} => {1}", nameof(progress.Method), progress.Method);

        report.Prefix = "";
        progress(99);
    }

    private class MyReport {
        public string Prefix { get; set; } = string.Empty;

        public void ReportProgress(int percentComplete) {
            Console.WriteLine(Prefix + percentComplete);
        }
    }

    private delegate void ProgressReporter(int percentComplete);
}
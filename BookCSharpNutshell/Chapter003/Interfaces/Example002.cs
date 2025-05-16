namespace Chapter003.Interfaces;

public static class Example002 {
    public static void UserMain() {
        var test = new Test();

        test.Method1();
        test.Method2();
    }

    private class Test : IDerivedInterface {
        public int Number { get; set; } = 10;
        public string Msg { get; set; } = "Hello";

        public void Method1() {
            Console.WriteLine("Method1 => {0} = {1}", nameof(Number), Number);
        }

        public void Method2() {
            Console.WriteLine("Method2 => {0} = {1}", nameof(Msg), Msg);
        }
    }

    private interface IBaseInterface {
        public int Number { get; set; }
        public void Method1();
    }

    private interface IDerivedInterface : IBaseInterface {
        public string Msg { get; set; }
        public void Method2();
    }
}
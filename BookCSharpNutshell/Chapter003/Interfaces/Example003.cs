namespace Chapter003.Interfaces;

public static class Example003 {
    public static void UserMain() {
        // Implementing multiple interfaces can sometimes result in a collision between member signatures.
        // You can resolve such collisions by explicitly implementing an interface member.

        var test = new Test();

        test.Foo();
        ((IInterface2)test).Foo(); //  To call an explicitly implemented member you have to cast to its interface
    }

    private class Test : IInterface1, IInterface2 {
        public void Foo() {
            Console.WriteLine("IInterface1.Foo()");
        }

        int IInterface2.Foo() {
            Console.WriteLine("IInterface2.Foo()");
            return 0;
        }
    }

    private interface IInterface1 {
        public void Foo();
    }

    private interface IInterface2 {
        public int Foo();
    }
}
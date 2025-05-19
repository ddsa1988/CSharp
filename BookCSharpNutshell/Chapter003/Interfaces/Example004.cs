namespace Chapter003.Interfaces;

public static class Example004 {
    public static void UserMain() {
        // An implicitly implemented interface member is, by default, sealed.
        // It must be marked virtual or abstract in the base class in order to be overridden.

        var obj = new DerivedClass();

        obj.Foo();

        // Calling the interface member through either the base class or the interface calls the subclass’s implementation.
        // ((IMyInterface)obj).Foo();
        // ((BaseClass)obj).Foo();
    }

    private class BaseClass : IMyInterface {
        public virtual void Foo() {
            Console.WriteLine("BaseClass.Foo()");
        }
    }

    private class DerivedClass : BaseClass {
        public override void Foo() {
            Console.WriteLine("DerivedClass.Foo()");
        }
    }

    private interface IMyInterface {
        public void Foo();
    }
}
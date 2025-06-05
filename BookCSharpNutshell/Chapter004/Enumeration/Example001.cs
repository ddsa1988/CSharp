namespace Chapter004.Enumeration;

public static class Example001 {
    public static void Run() {
        // An enumerator is a read-only, forward-only cursor over a sequence of values.
        // An enumerable object is the logical representation of a sequence. It is not
        // itself a cursor but an object that produces cursors over itself. 

        const string msg = "Hello";

        using CharEnumerator chars = msg.GetEnumerator();
        
        while (chars.MoveNext()) {
            Console.Write(chars.Current + " ");
        }
    }
}
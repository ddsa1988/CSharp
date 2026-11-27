When you want to programmatically create additional threads to carry on some unit of work, follow this
predictable process when using the types of the System.Threading namespace:

1. Create a method to be the entry point for the new thread.

2. Create a new ParameterizedThreadStart (or ThreadStart) delegate, passing the address of the 
method defined in step 1 to the constructor.

3. Create a Thread object, passing the ParameterizedThreadStart/ThreadStart delegate as a constructor argument.

4. Establish any initial thread characteristics (name, priority, etc.).

5.Call the Thread.Start() method. This starts the thread at the method referenced by the 
delegate created in step 2 as soon as possible.
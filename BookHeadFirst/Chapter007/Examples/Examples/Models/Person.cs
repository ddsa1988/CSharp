namespace Examples.Models;

public interface IEmployee {
    public int Id { get; set; }
    public float Salary { get; set; }
}

public class Person {
    public string Name { get; init; } = string.Empty;
}

public class Coordinator : Person, IEmployee {
    public int Id { get; set; }
    public float Salary { get; set; }
}

public class Manager : Person, IEmployee {
    public int Id { get; set; }
    public float Salary { get; set; }
}
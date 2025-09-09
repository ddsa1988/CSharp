using Examples.Interfaces;

namespace Examples.Models;

public class Manager : Person, IEmployee {
    public int Id { get; set; }
    public float Salary { get; set; }
}
using Examples.Interface.Interfaces;

namespace Examples.Interface.Models;

public class Manager : Person, IEmployee {
    public int Id { get; set; }
    public float Salary { get; set; }
}
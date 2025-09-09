using Examples.Interface.Interfaces;

namespace Examples.Interface.Models;

public class Coordinator : Person, IEmployee {
    public int Id { get; set; }
    public float Salary { get; set; }
}
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class Queen : Bee {
    public override float CostPerShift { get; init; } = 2.15f;

    public Queen() : base(Job.Queen) { }
}
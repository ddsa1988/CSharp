namespace BeehiveManagementSystem.Models;

public class NectarCollector : Bee {
    public override float CostPerShift { get; init; } = 1.95f;

    public NectarCollector() : base(Enums.Job.NectarCollector) { }
}
namespace BeehiveManagementSystem.Models;

public class EggCare : Bee {
    public override float CostPerShift { get; init; } = 1.35f;

    public EggCare() : base(Enums.Job.EggCare) { }
}
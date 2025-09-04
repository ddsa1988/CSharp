using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class EggCare : Bee {
    private const float CareProgressPerShift = 0.15f;
    private readonly Queen _queen;
    public override float CostPerShift => 1.35f;

    public EggCare(Queen queen) : base(BeeJob.EggCare) {
        _queen = queen;
    }

    protected override void DoJob() {
        _queen.CareForEggs(CareProgressPerShift);
    }
}
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class NectarCollector : Bee {
    private const float NectarCollectedPerShift = 33.25f;
    public override float CostPerShift => 1.95f;

    public NectarCollector() : base(BeeJob.NectarCollector) { }

    protected override void DoJob() {
        HoneyVault.CollectNectar(NectarCollectedPerShift);
    }
}
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class HoneyManufacturer : Bee {
    private const float NectarProcessedPerShift = 33.15f;
    public override float CostPerShift => 1.7f;

    public HoneyManufacturer() : base(BeeJob.HoneyManufacturer) { }

    protected override void DoJob() {
        HoneyVault.ConvertNectarToHoney(NectarProcessedPerShift);
    }
}
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class HoneyManufacturer : Bee {
    private const float NectarProcessedPerShift = 33.15f;

    protected override float CostPerShift => 1.7f;

    public HoneyManufacturer() : base(Job.HoneyManufacturer) { }

    protected override void DoJob() {
        HoneyVault.ConvertNectarToHoney(NectarProcessedPerShift);
    }
}
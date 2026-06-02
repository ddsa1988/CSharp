using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class HoneyManufacturer : Bee {
    public override float CostPerShift { get; init; } = 1.7f;

    public HoneyManufacturer() : base(Job.HoneyManufacturer) { }
}
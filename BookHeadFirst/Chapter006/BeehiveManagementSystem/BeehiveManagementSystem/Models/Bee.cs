namespace BeehiveManagementSystem.Models;

public class Bee {
    public required string Job { get; set; }
    public readonly float CostPerShift = 0f;

    public void WorkTheNextShift() { }

    protected virtual void DoJob() { }
}
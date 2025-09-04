using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class Bee {
    public BeeJob Job { get; private set; }
    public virtual float CostPerShift { get; }

    protected Bee(BeeJob job) {
        Job = job;
    }

    public void WorkTheNextShift() {
        if (!HoneyVault.ConsumeHoney(CostPerShift)) return;

        DoJob();
    }

    protected virtual void DoJob() { }
}
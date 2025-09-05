using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public abstract class Bee {
    protected abstract float CostPerShift { get; }
    public BeeJob Job { get; private set; }

    protected Bee(BeeJob job) {
        Job = job;
    }

    public void WorkTheNextShift() {
        if (!HoneyVault.ConsumeHoney(CostPerShift)) return;

        DoJob();
    }

    protected abstract void DoJob();
}
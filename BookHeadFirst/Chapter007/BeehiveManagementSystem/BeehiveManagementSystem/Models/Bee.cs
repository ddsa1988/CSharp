using BeehiveManagementSystem.Enums;
using BeehiveManagementSystem.Interfaces;

namespace BeehiveManagementSystem.Models;

public abstract class Bee : IWorker {
    protected abstract float CostPerShift { get; }
    public BeeJob Job { get; }

    protected Bee(BeeJob job) {
        Job = job;
    }

    public void WorkTheNextShift() {
        if (!HoneyVault.ConsumeHoney(CostPerShift)) return;

        DoJob();
    }

    protected abstract void DoJob();
}
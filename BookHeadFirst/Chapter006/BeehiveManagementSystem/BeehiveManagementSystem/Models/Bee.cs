using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public abstract class Bee {
    public Job Job { get; }
    protected abstract float CostPerShift { get; }

    protected Bee(Job job) {
        Job = job;
    }

    public void WorkNextShift() {
        bool isEnoughHoney = HoneyVault.ConsumeHoney(CostPerShift);

        if (!isEnoughHoney) return;

        DoJob();
    }

    protected abstract void DoJob();
}
using System;
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class Bee {
    public Job Job { get; init; }
    public virtual float CostPerShift { get; init; }

    protected Bee(Job job) {
        Job = job;
    }

    public void WorkNextShift() {
        bool isEnoughHoney = HoneyVault.ConsumeHoney(CostPerShift);

        if (!isEnoughHoney) return;

        DoJob();
    }

    protected virtual void DoJob() {
        throw new NotImplementedException();
    }
}
using System;
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class Bee {
    public Job Job { get; }
    protected virtual float CostPerShift => 0.0f;

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
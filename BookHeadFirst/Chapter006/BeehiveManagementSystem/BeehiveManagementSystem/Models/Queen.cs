using System;
using System.Collections.Generic;
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public class Queen : Bee {
    private const float EggsPerShit = 0.45f;
    private const float HoneyPerUnassignedWorker = 0.5f;
    private readonly List<Bee> _workers = [];
    private float _eggs;
    private int _unassignedWorkers = 3;
    public override float CostPerShift { get; init; } = 2.15f;

    public Queen() : base(Job.Queen) { }

    private void AddWorker(Bee worker) {
        if (_unassignedWorkers < 1) return;

        _workers.Add(worker);
        _unassignedWorkers--;
    }

    public void AssignBee(Job job) {
        switch (job) {
            case Job.NectarCollector:
                AddWorker(new NectarCollector());
                break;
            case Job.HoneyManufacturer:
                AddWorker(new HoneyManufacturer());
                break;
            case Job.EggCare:
                AddWorker(new EggCare());
                break;
            case Job.Queen:
            default:
                throw new ArgumentException($"Invalid job provided: {nameof(job)}");
        }
    }

    protected override void DoJob() {
        throw new NotImplementedException();
    }
}
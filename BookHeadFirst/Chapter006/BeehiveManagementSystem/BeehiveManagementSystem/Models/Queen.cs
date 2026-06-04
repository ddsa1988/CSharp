using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public partial class Queen : Bee {
    private const float EggsPerShit = 0.45f;
    private const float HoneyPerUnassignedWorker = 0.5f;
    private readonly List<IWorker> _workers = [];
    private float _eggs;
    private float _unassignedWorkers;
    protected override float CostPerShift => 2.15f;
    public string StatusReport { get; private set; } = string.Empty;

    public Queen() : base(Job.Queen) {
        _unassignedWorkers = 3;

        AssignBee(Job.NectarCollector);
        AssignBee(Job.HoneyManufacturer);
        AssignBee(Job.EggCare);
    }

    private void UpdateStatusReport() {
        StatusReport = HoneyVault.StatusReport + '\n';
        StatusReport += $"\nEgg count: {_eggs:0.0}";
        StatusReport += $"\nUnassigned workers: {_unassignedWorkers:0.0}";
        StatusReport += $"\n{WorkerStatus(Job.NectarCollector)}";
        StatusReport += $"\n{WorkerStatus(Job.HoneyManufacturer)}";
        StatusReport += $"\n{WorkerStatus(Job.EggCare)}";
        StatusReport += $"\nTOTAL WORKERS: {_workers.Count}";
    }

    [GeneratedRegex("([a-z0-9])([A-Z])")]
    private static partial Regex CamelCaseSpacing();

    private string WorkerStatus(Job job) {
        int count = _workers.Count(bee => bee.Job == job);
        string jobName = CamelCaseSpacing().Replace(job.ToString(), "$1 $2");

        string status = $"{count} {jobName} bee{(count > 2 ? "s" : "")}";

        return status;
    }

    private void AddWorker(IWorker worker) {
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
                AddWorker(new EggCare(this));
                break;
            case Job.Queen:
            default:
                throw new ArgumentException($"Invalid job provided: {job.ToString()}");
        }

        UpdateStatusReport();
    }

    public void CareForEggs(float eggsToConvert) {
        if (eggsToConvert <= 0) return;
        if (eggsToConvert > _eggs) return;

        _eggs -= eggsToConvert;
        _unassignedWorkers += eggsToConvert;
    }

    protected override void DoJob() {
        _eggs += EggsPerShit;

        foreach (IWorker worker in _workers) {
            worker.WorkNextShift();
        }

        HoneyVault.ConsumeHoney(_unassignedWorkers * HoneyPerUnassignedWorker);

        UpdateStatusReport();
    }
}
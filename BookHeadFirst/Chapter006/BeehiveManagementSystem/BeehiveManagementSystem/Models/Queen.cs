using System;
using System.Collections.Generic;
using BeehiveManagementSystem.Enums;
using BeehiveManagementSystem.Extensions;

namespace BeehiveManagementSystem.Models;

public class Queen : Bee {
    private const float EggsPerShift = 0.45f;
    private const float HoneyPerUnassignedWorker = 0.5f;
    private float _eggs;
    private float _unassignedWorkers = 3;
    private readonly List<Bee> _workers = [];
    public string StatusReport { get; private set; } = string.Empty;
    public override float CostPerShift => 2.15f;

    public Queen() : base(BeeJob.Queen) {
        AssignBee(BeeJob.NectarCollector);
        AssignBee(BeeJob.HoneyManufacturer);
        AssignBee(BeeJob.EggCare);
    }

    private void AddWorker(Bee worker) {
        if (_unassignedWorkers < 1) return;

        _unassignedWorkers--;
        _workers.Add(worker);
    }

    private void UpdateStatusReport() {
        StatusReport = $"{HoneyVault.StatusReport}\n" +
                       $"\nEgg count: {_eggs:0.0}\nUnassigned workers: {_unassignedWorkers:0.0}\n" +
                       $"{WorkerStatus(BeeJob.NectarCollector)}\n{WorkerStatus(BeeJob.HoneyManufacturer)}" +
                       $"\n{WorkerStatus(BeeJob.EggCare)}\nTOTAL WORKERS: {_workers.Count}";
    }

    public void CareForEggs(float eggsToConvert) {
        if (_eggs < eggsToConvert) return;

        _eggs -= eggsToConvert;
        _unassignedWorkers += eggsToConvert;
    }

    private string WorkerStatus(BeeJob job) {
        string jobName = job.ToString().PascalCaseToTitleCase();
        int count = 0;

        foreach (Bee worker in _workers) {
            if (worker.Job == job) count++;
        }

        return $"{count} {jobName} bee{(count == 1 ? "" : "s")}";
    }

    public void AssignBee(BeeJob job) {
        switch (job) {
            case BeeJob.NectarCollector:
                AddWorker(new NectarCollector());
                break;
            case BeeJob.HoneyManufacturer:
                AddWorker(new HoneyManufacturer());
                break;
            case BeeJob.EggCare:
                AddWorker(new EggCare(this));
                break;
            case BeeJob.Queen:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(job), job, null);
        }

        UpdateStatusReport();
    }

    protected override void DoJob() {
        _eggs += EggsPerShift;

        foreach (Bee worker in _workers) {
            worker.WorkTheNextShift();
        }

        HoneyVault.ConsumeHoney(_unassignedWorkers * HoneyPerUnassignedWorker);
        UpdateStatusReport();
    }
}
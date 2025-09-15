using System;
using System.Collections.Generic;
using System.ComponentModel;
using BeehiveManagementSystem.Enums;
using BeehiveManagementSystem.Extensions;
using BeehiveManagementSystem.Interfaces;

namespace BeehiveManagementSystem.Models;

public class Queen : Bee, INotifyPropertyChanged {
    private const float EggsPerShift = 0.45f;
    private const float HoneyPerUnassignedWorker = 0.5f;
    private float _eggs;
    private float _unassignedWorkers = 3;
    private readonly List<IWorker> _workers = [];
    public string StatusReport { get; private set; } = string.Empty;
    protected override float CostPerShift => 2.15f;
    public event PropertyChangedEventHandler? PropertyChanged;

    public Queen() : base(BeeJob.Queen) {
        AssignBee(BeeJob.NectarCollector);
        AssignBee(BeeJob.HoneyManufacturer);
        AssignBee(BeeJob.EggCare);
    }

    private void AddWorker(IWorker worker) {
        if (_unassignedWorkers < 1) return;

        _unassignedWorkers--;
        _workers.Add(worker);
    }

    private void UpdateStatusReport() {
        StatusReport = $"{HoneyVault.StatusReport}\n" +
                       $"\nEgg count: {_eggs:0.0}\nUnassigned workers: {_unassignedWorkers:0.0}\n" +
                       $"{WorkerStatus(BeeJob.NectarCollector)}\n{WorkerStatus(BeeJob.HoneyManufacturer)}" +
                       $"\n{WorkerStatus(BeeJob.EggCare)}\nTOTAL WORKERS: {_workers.Count}";

        OnPropertyChanged(nameof(StatusReport));
    }

    public void CareForEggs(float eggsToConvert) {
        if (_eggs < eggsToConvert) return;

        _eggs -= eggsToConvert;
        _unassignedWorkers += eggsToConvert;
    }

    private string WorkerStatus(BeeJob job) {
        string jobName = job.ToString().PascalCaseToTitleCase();
        int count = 0;

        foreach (IWorker worker in _workers) {
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

        foreach (IWorker worker in _workers) {
            worker.WorkTheNextShift();
        }

        HoneyVault.ConsumeHoney(_unassignedWorkers * HoneyPerUnassignedWorker);
        UpdateStatusReport();
    }

    private void OnPropertyChanged(string propertyName) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Interfaces;

public interface IWorker {
    public BeeJob Job { get; }

    public void WorkTheNextShift();
}
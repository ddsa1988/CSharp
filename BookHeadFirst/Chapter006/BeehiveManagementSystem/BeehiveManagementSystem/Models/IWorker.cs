using BeehiveManagementSystem.Enums;

namespace BeehiveManagementSystem.Models;

public interface IWorker {
    public Job Job { get; }
    public void WorkNextShift();
}
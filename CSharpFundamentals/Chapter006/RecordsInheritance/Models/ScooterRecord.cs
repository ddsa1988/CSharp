namespace RecordsInheritance.Models;

internal record class ScooterRecord(string Make, string Model) : MotorCycleRecord(Make, Model);
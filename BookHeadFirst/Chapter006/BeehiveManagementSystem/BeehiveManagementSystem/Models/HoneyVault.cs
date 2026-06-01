using System;

namespace BeehiveManagementSystem.Models;

public static class HoneyVault {
    private static float _honey = 25f;
    private static float _nectar = 100f;
    public const float HoneyConversionRate = 0.19f;
    public const float LowLevelWarning = 10f;
    public static string StatusReport { get; } = string.Empty;

    public static void CollectNectar(float amount) {
        throw new NotImplementedException();
    }

    public static void ConvertNectarToHoney(float amount) {
        throw new NotImplementedException();
    }

    public static bool ConsumeHoney(float amount) {
        throw new NotImplementedException();
    }
}
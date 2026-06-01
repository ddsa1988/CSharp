using System;

namespace BeehiveManagementSystem.Models;

public static class HoneyVault {
    private static float _honey = 25f;
    private static float _nectar = 100f;
    private const float HoneyConversionRate = 0.19f;
    private const float LowLevelWarning = 10f;
    public static string StatusReport { get; } = string.Empty;

    public static void CollectNectar(float amount) {
        throw new NotImplementedException();
    }

    public static void ConvertNectarToHoney(float amount) {
        if (amount <= 0) return;
        if (_nectar <= 0) return;

        float nectarAmount = amount < _nectar ? amount : _nectar;

        _honey += nectarAmount * HoneyConversionRate;
        _nectar -= nectarAmount;
    }

    public static bool ConsumeHoney(float amount) {
        throw new NotImplementedException();
    }
}
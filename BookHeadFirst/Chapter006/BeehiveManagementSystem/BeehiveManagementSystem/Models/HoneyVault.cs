namespace BeehiveManagementSystem.Models;

public static class HoneyVault {
    private const float HoneyConversionRate = 0.19f;
    private const float LowLevelWarning = 10f;
    public static float Honey { get; private set; } = 25f;
    public static float Nectar { get; private set; } = 100f;

    public static string StatusReport {
        get {
            string status = $"Vault report:\n{Honey:0.0} units of honey\n{Nectar:0.0} units of nectar";
            string warnings = "";

            if (Honey < LowLevelWarning) {
                warnings += "\nLOW HONEY - ADD A HONEY MANUFACTURER";
            }

            if (Nectar < LowLevelWarning) {
                warnings += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
            }

            return status + warnings;
        }
    }

    public static void CollectNectar(float amount) {
        if (amount <= 0) return;

        Nectar += amount;
    }

    public static void ConvertNectarToHoney(float amount) {
        if (amount <= 0) return;
        if (Nectar <= 0) return;

        float nectarToConvert = amount < Nectar ? amount : Nectar;

        Honey += nectarToConvert * HoneyConversionRate;
        Nectar -= nectarToConvert;
    }

    public static bool ConsumeHoney(float amount) {
        if (amount <= 0) return false;
        if (amount > Honey) return false;

        Honey -= amount;

        return true;
    }
}
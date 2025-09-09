namespace BeehiveManagementSystem.Models;

public static class HoneyVault {
    private static float _honey;
    private static float _nectar;
    private const float NectarConversionRatio = 0.19f;
    private const float LowLevelWarning = 10f;

    static HoneyVault() {
        _honey = 25f;
        _nectar = 100f;
    }

    public static string StatusReport {
        get {
            string msg = $"Vault report:\n{_honey:0.0} units of honey\n{_nectar:0.0} units of nectar";
            string warning = "";

            if (_honey < LowLevelWarning) {
                warning += "\nLow Honey - Add a honey manufacturer";
            }

            if (_nectar < LowLevelWarning) {
                warning += "\nLow Nectar - Add a nectar collector";
            }

            return msg + warning;
        }
    }

    public static void CollectNectar(float amount) {
        if (amount < 0) return;

        _nectar += amount;
    }

    public static void ConvertNectarToHoney(float amount) {
        float nectarToConvert = amount;

        if (nectarToConvert < 0) return;

        if (nectarToConvert > _nectar) {
            nectarToConvert = _nectar;
        }

        _nectar -= nectarToConvert;
        _honey += nectarToConvert * NectarConversionRatio;
    }

    public static bool ConsumeHoney(float amount) {
        if (amount < 0) return false;

        if (amount > _honey) return false;

        _honey -= amount;

        return true;
    }
}
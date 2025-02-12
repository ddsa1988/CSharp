namespace GetStartedApp.Models;

public static class ConvertTemperature {
    public static float CelsiusToFahrenheit(float celsius) {
        float fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }
}
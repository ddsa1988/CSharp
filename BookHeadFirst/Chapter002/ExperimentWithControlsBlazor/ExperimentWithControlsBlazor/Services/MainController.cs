using Microsoft.AspNetCore.Components;

namespace ExperimentWithControlsBlazor.Services;

public class MainController {
    public string DisplayValue { get; private set; } = string.Empty;

    public void UpdateValue(ChangeEventArgs e) {
        DisplayValue = e.Value?.ToString() ?? string.Empty;
    }

    public void ButtonClick(string value) {
        DisplayValue = value;
    }

    public void UpdateNumericValue(ChangeEventArgs e) {
        bool isValueValid = int.TryParse(e.Value?.ToString(), out int value);

        if (!isValueValid) return;

        DisplayValue = value.ToString();
    }
}
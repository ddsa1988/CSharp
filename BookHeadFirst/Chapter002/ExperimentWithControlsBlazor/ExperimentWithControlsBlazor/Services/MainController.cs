using Microsoft.AspNetCore.Components;

namespace ExperimentWithControlsBlazor.Services;

public class MainController {
    public string DisplayValue { get; private set; } = string.Empty;

    public void UpdateValue(ChangeEventArgs e) {
        DisplayValue = e.Value?.ToString() ?? string.Empty;
    }
}
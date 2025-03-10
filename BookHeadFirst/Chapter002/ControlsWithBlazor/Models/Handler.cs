using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace ControlsWithBlazor.Models;

public static class Handler {
    public static string DisplayValue { get; private set; } = string.Empty;
    public static int NumberButtons { get; private set; } = 5;

    public static void UpdateValue(ChangeEventArgs e) {
        DisplayValue = e.Value?.ToString() ?? string.Empty;
    }

    public static void UpdateValueNumeric(ChangeEventArgs e) {
        bool isNumber = double.TryParse(e.Value?.ToString(), out double number);

        if (!isNumber) return;

        DisplayValue = number.ToString(CultureInfo.InvariantCulture);
    }

    public static void ButtonClick(string displayValue) {
        DisplayValue = displayValue;
    }
}
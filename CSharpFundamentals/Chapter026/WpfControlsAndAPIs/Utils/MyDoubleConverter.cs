using System.Globalization;
using Avalonia.Data.Converters;

namespace WpfControlsAndAPIs.Utils;

internal class MyDoubleConverter : IValueConverter {
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture) {
        bool isValueValid = double.TryParse(value?.ToString(), out double doubleValue);

        if (!isValueValid) return 0;

        return (int)doubleValue;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) {
        return value;
    }
}
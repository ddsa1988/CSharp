using System;
using Avalonia.Controls;

namespace Controls.Views;

public partial class DateAndTimeWindow : Window {
    public DateAndTimeWindow() {
        InitializeComponent();
    }

    private void DatePicker1_OnSelectedDateChanged(object? sender, DatePickerSelectedValueChangedEventArgs e) {
        Console.WriteLine("Old date: " + e.OldDate);
        Console.WriteLine("New date: " + e.NewDate);
    }
}
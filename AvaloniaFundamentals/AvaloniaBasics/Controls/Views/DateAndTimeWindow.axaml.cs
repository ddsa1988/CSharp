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


    private void Calendar1_OnDisplayDateChanged(object? sender, CalendarDateChangedEventArgs e) {
        Console.WriteLine("Old date: " + e.RemovedDate);
        Console.WriteLine("New date: " + e.AddedDate);
    }

    private void CalendarDatePicker1_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e) {
        if (e.RemovedItems.Count == 0) return;

        Console.WriteLine("Old date: " + e.RemovedItems[0]);
        Console.WriteLine("New date: " + e.AddedItems[0]);
    }

    private void TimePicker1_OnSelectedTimeChanged(object? sender, TimePickerSelectedValueChangedEventArgs e) {
        Console.WriteLine("Old time: " + e.OldTime);
        Console.WriteLine("New time: " + e.NewTime);
    }
}
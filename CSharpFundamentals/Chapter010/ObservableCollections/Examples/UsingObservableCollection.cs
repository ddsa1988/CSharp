using System.Collections.ObjectModel;
using ObservableCollections.Models;

namespace ObservableCollections.Examples;

internal static class UsingObservableCollection {
    public static void Run() {
        // Create a collection to observe
        var people = new ObservableCollection<Person>() {
            new("John", "Doe", 25),
            new("Jane", "Smith", 21),
        };

        // Wire up the CollectionChanged event
        people.CollectionChanged += people_CollectionChanged;

        people.Add(new Person("Fred", "Mercury", 28));

        Console.WriteLine();

        people.RemoveAt(0);
    }

    private static void people_CollectionChanged(object? sender,
        System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
        Console.WriteLine("Action for this event: " + e.Action);

        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove) {
            Console.WriteLine("Here are the Old items: ");

            if (e.OldItems == null) return;

            foreach (object item in e.OldItems) {
                Console.WriteLine(item.ToString());
            }

            return;
        }

        if (e.Action != System.Collections.Specialized.NotifyCollectionChangedAction.Add) return;

        Console.WriteLine("Here are the New items: ");

        if (e.NewItems == null) return;

        foreach (object item in e.NewItems) {
            Console.WriteLine(item.ToString());
        }
    }
}
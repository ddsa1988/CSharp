using System.Text;

namespace CSharpBasics.Chapter02;

public class Inheritance {
    public static void MyMain() {
        Asset a1 = new Asset() { Name = "Test1" };
        Console.WriteLine(a1);

        Stock s1 = new Stock("Test2", 600);
        Console.WriteLine(s1);
        
        House m1 = new House("Test3", 1200);
        Console.WriteLine(m1);
    }

    private class Asset {
        private string name = string.Empty;

        public Asset() { }

        public Asset(string name) {
            Name = name;
        }

        public string Name {
            get => name;
            set => name = !(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) ? value : "";
        }

        public override string ToString() {
            return "Name: " + Name;
        }
    }

    private class Stock : Asset {
        private int sharedOwned;

        public Stock() { }

        public Stock(string name, int sharedOwned) : base(name) {
            SharedOwned = sharedOwned;
        }

        public int SharedOwned {
            get => sharedOwned;
            set => sharedOwned = value > 0 ? value : 0;
        }

        public override string ToString() {
            return base.ToString() + $", Shared owned: {SharedOwned:F2}";
        }
    }

    private class House : Asset {
        private double mortgage;

        public House() { }

        public House(string name, double mortgage) : base(name) {
            Mortgage = mortgage;
        }

        public double Mortgage {
            get => mortgage;
            set => mortgage = value > 0 ? value : 0;
        }

        public override string ToString() {
            return base.ToString() + $", Mortgage: {Mortgage:C2}";
        }
    }
}
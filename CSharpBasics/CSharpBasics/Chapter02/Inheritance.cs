using System.Text;

namespace CSharpBasics.Chapter02;

public class Inheritance {
    public static void MyMain() {
        Asset a1 = new Asset() { Name = "Test" };
        Console.WriteLine(a1);
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
}
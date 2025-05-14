namespace Chapter003.Inheritance;

public static class Example010 {
    public static void UserMain() {
        var circle = new Circle() { Radius = 10 };

        Console.WriteLine("{0} => {1}: {2}", nameof(circle), nameof(circle.GetArea), circle.GetArea());
        Console.WriteLine("{0} => {1}: {2}", nameof(circle), nameof(circle.GetPerimeter),
            circle.GetPerimeter());
    }

    private abstract class Shape {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    private class Circle : Shape {
        private double _radius;

        public double Radius {
            get => _radius;
            set => _radius = value > 0 ? value : 0;
        }

        public override double GetArea() {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter() {
            return 2 * Math.PI * Radius;
        }
    }
}
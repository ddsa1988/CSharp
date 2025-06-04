namespace Chapter003.Inheritance;

public static class Example010 {
    public static void Run() {
        var circle = new Circle() { Radius = 10 };
        var rectangle = new Rectangle() { Width = 10, Height = 10 };

        Console.WriteLine("{0} => {1}: {2}", nameof(circle), nameof(circle.GetArea), circle.GetArea());
        Console.WriteLine("{0} => {1}: {2}", nameof(circle), nameof(circle.GetPerimeter),
            circle.GetPerimeter());

        Console.WriteLine();

        Console.WriteLine("{0} => {1}: {2}", nameof(rectangle), nameof(rectangle.GetArea), rectangle.GetArea());
        Console.WriteLine("{0} => {1}: {2}", nameof(rectangle), nameof(rectangle.GetPerimeter),
            circle.GetPerimeter());

        Console.WriteLine();

        var shapes = new Shape[] { circle, rectangle };

        foreach (Shape shape in shapes) {
            Console.WriteLine("{0} => {1}: {2}", nameof(shape), nameof(shape.GetArea), shape.GetArea());
            Console.WriteLine("{0} => {1}: {2}", nameof(shape), nameof(shape.GetPerimeter), shape.GetPerimeter());
        }
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

    private class Rectangle : Shape {
        private double _width;
        private double _height;

        public double Width {
            get => _width;
            set => _width = value > 0 ? value : 0;
        }

        public double Height {
            get => _height;
            set => _height = value > 0 ? value : 0;
        }

        public override double GetArea() {
            return Width * Height;
        }

        public override double GetPerimeter() {
            return 2 * (Width + Height);
        }
    }
}
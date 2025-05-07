namespace Chapter003.Classes;

public static class Example003 {
    public static void UserMain() {
        // Deconstructor assigns fields to a set of variables.

        var rect = new Rectangle(10.5f, 22.5f);
        Console.WriteLine("{0} => {1}\n", nameof(rect), rect);

        {
            rect.Deconstruct(out float width, out float height);
            Console.WriteLine("{0} => {1}", nameof(width), width);
            Console.WriteLine("{0} => {1}\n", nameof(height), height);
        }

        {
            (float width, float height) = rect;
            Console.WriteLine("{0} => {1}", nameof(width), width);
            Console.WriteLine("{0} => {1}\n", nameof(height), height);
        }

        {
            var (width, height) = rect;
            Console.WriteLine("{0} => {1}", nameof(width), width);
            Console.WriteLine("{0} => {1}", nameof(height), height);
        }
    }

    private class Rectangle {
        public readonly float Width;
        public readonly float Height;

        public Rectangle(float width, float height) {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out float height) {
            width = Width;
            height = Height;
        }

        public override string ToString() {
            return $"Rectangle {{ Width = {Width}, Height = {Height} }}";
        }
    }
}
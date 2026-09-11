namespace CustomInterfaces.Interfaces;

internal interface IRegularPointy : IPointy {
    public int SideLength { get; set; }
    public int NumberOfSides { get; set; }
    public int Perimeter => SideLength * NumberOfSides;
    public static string ExampleProperty { get; set; }

    static IRegularPointy() {
        ExampleProperty = "Foo";
    }
}
namespace CustomInterfaces.Interfaces;

internal interface IRegularPointy : IPointy {
    public int SideLenght { get; set; }
    public int NumberOfSides { get; set; }
    public int Perimeter => SideLenght * NumberOfSides;
}
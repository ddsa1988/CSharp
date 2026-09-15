namespace CloneablePoint.Models;

internal class PointWithReferenceTypes : ICloneable {
    public int X { get; set; }
    public int Y { get; set; }
    public PointDescription Description { get; set; } = new();

    public PointWithReferenceTypes(int xPos, int yPos, string name) {
        X = xPos;
        Y = yPos;
        Description.Name = name;
    }

    public PointWithReferenceTypes(int xPos, int yPos) {
        X = xPos;
        Y = yPos;
    }

    public PointWithReferenceTypes() { }


    public override string ToString() {
        return
            $"Point {{ {nameof(X)} = {X}, {nameof(Y)} = {Y}, {nameof(Description.Name)} = {Description.Name},  {nameof(Description.Id)} = {Description.Id} }}";
    }

    // Return a copy of the current object
    public object Clone() {
        if (MemberwiseClone() is not PointWithReferenceTypes newPoint) return new PointWithReferenceTypes();

        var newDescription = new PointDescription() { Name = Description.Name };

        newPoint.Description = newDescription;

        return newPoint;
    }
}
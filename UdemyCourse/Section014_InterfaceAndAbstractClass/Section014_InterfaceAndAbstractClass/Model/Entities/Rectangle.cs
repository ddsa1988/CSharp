using System.Globalization;
using Section014_InterfaceAndAbstractClass.Model.Enum;

namespace Section014_InterfaceAndAbstractClass.Model.Entities; 

public class Rectangle : AbstractShape {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private double width;
    private double height;


    public Rectangle(double width, double height, Color shapeColor) {
        Width = width;
        Height = height;
        ShapeColor = shapeColor;
    }
    
    public double Width {
        get { return width; }
        set { width = value > 0 ? value : 0; }
    }

    public double Height {
        get { return height; }
        set { height = value > 0 ? value : 0; }
    }
    
    public override double Area() {
        return Width * Height;
    }

    public override string ToString() {
        return "Color: " + ShapeColor +
               "\nWidth: " + Width.ToString("F2", cultureInfo) +
               "\nHeight: " + Height.ToString("F2", cultureInfo) +
               "\nArea: " + Area().ToString("F2", cultureInfo);
    }
}
using System.Globalization;
using Section014_InterfaceAndAbstractClass.Model.Enum;

namespace Section014_InterfaceAndAbstractClass.Model.Entities; 

public class Circle : AbstractShape {

    private CultureInfo cultureInfo = CultureInfo.InvariantCulture;
    private double radius;

    public Circle(double radius, Color shapeColor) {
        Radius = radius;
        ShapeColor = shapeColor;
    }
    
    public double Radius {
        get { return radius; }
        set { radius = value > 0 ? value : 0; }
    }
    
    public override double Area() {
        double area = Math.PI * Math.Pow(radius, 2);

        return area;
    }

    public override string ToString() {
        return "Color: " + ShapeColor +
               "\nRadius: " + Radius.ToString("F2", cultureInfo) +
               "\nArea: " + Area().ToString("F2", cultureInfo);
    }
}
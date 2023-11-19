using Section014_InterfaceAndAbstractClass.Model.Enum;

namespace Section014_InterfaceAndAbstractClass.Model.Entities; 

public abstract class AbstractShape : IShape {
    
    public Color ShapeColor { get; set; }
    
    public abstract double Area();
}
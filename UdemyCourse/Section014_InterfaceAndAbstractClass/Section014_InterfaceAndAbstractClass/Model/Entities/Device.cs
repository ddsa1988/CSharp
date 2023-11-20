namespace Section014_InterfaceAndAbstractClass.Model.Entities; 

public abstract class Device {

    public string SerialNumber { get; set; } = "";

    public abstract void ProcessDoc(string document);
}
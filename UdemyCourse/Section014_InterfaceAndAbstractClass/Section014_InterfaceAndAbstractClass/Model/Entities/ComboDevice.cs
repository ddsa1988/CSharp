namespace Section014_InterfaceAndAbstractClass.Model.Entities; 

public class ComboDevice : Device, IScanner, IPrinter {
    
    public override void ProcessDoc(string document) {
        Console.WriteLine("Combo device processing: " + document);
    }

    public string Scan() {
        return "Combo device scan result";
    }

    public void Print(string document) {
        Console.WriteLine("Combo device printing: " + document);
    }
}
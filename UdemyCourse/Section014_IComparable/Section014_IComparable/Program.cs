using Section014_IComparable.Entities;

namespace Section014_IComparable;

public class Program {
    public static void Main(string[] args) {

        string separator = Path.AltDirectorySeparatorChar.ToString();
        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Names.txt";
        List<Employee> employees = new List<Employee>();

        try {
            using (StreamReader sr = File.OpenText(sourcePath)) {
                while (!sr.EndOfStream) {
                    string? line = sr.ReadLine();

                    if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line)) continue;
                    
                    Employee employee = new Employee(line);
                    employees.Add(employee);
                }
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        
        employees.Sort();
        
        foreach (Employee emp in employees) {
            Console.WriteLine(emp);
        }
    }
}
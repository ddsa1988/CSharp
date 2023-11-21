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
                    
                    Employee employee = new Employee(line);

                    if (string.IsNullOrEmpty(employee.Name) || string.IsNullOrWhiteSpace(employee.Name)) continue;

                    employees.Add(employee);
                }
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Normal order:" +
                          "");
        foreach (Employee employee in employees) {
            Console.WriteLine(employee);
        }

        Console.WriteLine();

        employees.Sort();

        Console.WriteLine("Sorted by name ascending:");
        
        foreach (Employee employee in employees) {
            Console.WriteLine(employee);
        }
        
        Console.WriteLine();

        employees.Sort(new Employee.SortBySalaryAscending());
        
        Console.WriteLine("Sorted by salary ascending:");
        
        foreach (Employee employee in employees) {
            Console.WriteLine(employee);
        }
        
        Console.WriteLine();

        employees.Sort(new Employee.SortBySalaryDescending());
        
        Console.WriteLine("Sorted by salary descending:");
        
        foreach (Employee emp in employees) {
            Console.WriteLine(emp);
        }
    }
}
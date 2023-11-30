using System.Globalization;
using Section017_LinqExercise.Entities;

namespace Section017_LinqExercise;

public class Exercise002 {
    public static void CallMain() {
        char separator = Path.AltDirectorySeparatorChar;
        string sourcePath = @$"..{separator}..{separator}..{separator}Files{separator}Employees.txt";
        List<Employee> employees = new List<Employee>();

        if (!File.Exists(sourcePath)) return;

        using StreamReader sr = new StreamReader(sourcePath);
        while (!sr.EndOfStream) {
            string? data = sr.ReadLine();

            if (!IsDataValid(data)) continue;

            string[] dataArray = data.Split(',');
            string name = dataArray[0];
            string email = dataArray[1];
            float salary = float.Parse(dataArray[2], CultureInfo.InvariantCulture);

            Employee employee = new Employee(name, email, salary);
            employees.Add(employee);

        }

        if (employees.Count == 0) return;

        float userInput = 2000F;

        //IEnumerable<string> result = employees.Where(e => e.Salary > userInput).OrderBy(e => e.Email).Select(e => e.Email);
        IEnumerable<string> result = from e in employees where e.Salary > userInput orderby e.Email select e.Email;

        Console.WriteLine("Email of people whose salary is more than $" + userInput + ":");
        PrintCollection(result);
        
        //float sum = employees.Where(e => e.Name.StartsWith('M')).Select(e => e.Salary).Sum();
        float sum = (from e in employees where e.Name.StartsWith('M') select e.Salary).Sum();
        Console.WriteLine("Sum of salary of people whose name starts with 'M': $" + sum.ToString("F2"));
    }

    private static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T obj in collection) {
            Console.WriteLine(obj);
        }

        Console.WriteLine();
    }

    private static bool IsDataValid(string data) {
        if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data)) return false;
        if (!data.Contains(',')) return false;

        string[] dataArray = data.Split(',');
        string name = dataArray[0];
        string email = dataArray[1];
        string salaryString = dataArray[2];

        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return false;
        if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email)) return false;

        try {
            float salary = float.Parse(salaryString);
        } catch (Exception e) {
            return false;
        }

        return true;
    }
}
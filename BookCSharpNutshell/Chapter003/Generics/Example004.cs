namespace Chapter003.Generics;

public static class Example004 {
    public static void UserMain() {
        // Constraints can be applied to a type parameter to require more specific type arguments.
        // The main purpose of type parameter constraints is to enable things that would otherwise be prohibited.

        var manageManagers = new ManageEmployees<Manager>();
        var manageAnalysts = new ManageEmployees<Analyst>();

        var manager1 = new Manager() { Name = "Manager 1", Id = 1, Salary = 15000 };
        var manager2 = new Manager() { Name = "Manager 2", Id = 2, Salary = 16000 };

        var analyst1 = new Analyst() { Name = "Analyst 1", Id = 10, Salary = 10000 };
        var analyst2 = new Analyst() { Name = "Analyst 2", Id = 11, Salary = 11000 };

        manageManagers.AddEmployee(manager1);
        manageManagers.AddEmployee(manager2);

        manageAnalysts.AddEmployee(analyst1);
        manageAnalysts.AddEmployee(analyst2);

        Console.WriteLine("Total managers salary: " + manageManagers.GetTotalSalary());
        Console.WriteLine("Total analysts salary: " + manageAnalysts.GetTotalSalary());
    }

    private class ManageEmployees<T> where T : IEmployee {
        private readonly List<T> _employees = [];

        public void AddEmployee(T item) {
            int index = _employees.FindIndex(employee => employee.Id == item.Id);

            if (index != -1) return;

            _employees.Add(item);
        }

        public void RemoveEmployee(T item) {
            int index = _employees.FindIndex(employee => employee.Id == item.Id);

            if (index == -1) return;

            _employees.RemoveAt(index);
        }

        public double GetTotalSalary() {
            double total = 0;

            foreach (T t in _employees) {
                total += t.Salary;
            }

            return total;
        }
    }

    private class Manager : IEmployee {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
        public double Salary { get; set; }
    }

    private class Analyst : IEmployee {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
        public double Salary { get; set; }
    }

    private interface IEmployee {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }
    }
}
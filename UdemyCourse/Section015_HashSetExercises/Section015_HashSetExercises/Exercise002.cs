namespace Section015_hashSetExercises; 

public class Exercise002 {
    public static void MyMain() {

        const int courses = 3;

        HashSet<int>[] courseStudents = new HashSet<int>[courses];
        HashSet<int> totalStudents = new HashSet<int>();

        for (int i = 0; i < courses; i++) {
            int numberOfStudents;

            while (true) {
                try {
                    Console.Write($"How many students for course {i + 1}: ");
                    numberOfStudents = int.Parse(Console.ReadLine());

                    if (numberOfStudents < 0) {
                        throw new Exception("Number must be equal or greater than zero.");
                    }

                    break;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

            courseStudents[i] = new HashSet<int>();

            Console.WriteLine();

            for (int j =  0; j < numberOfStudents; j++) {
                while (true) {
                    try {
                        Console.Write($"Student #{j + 1} id: ");
                        int id = int.Parse(Console.ReadLine());

                        if (id < 1) {
                            throw new Exception("Id must be greater than zero.");
                        }

                        courseStudents[i].Add(id);

                        break;
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            totalStudents.UnionWith(courseStudents[i]);
            Console.WriteLine();
        }

        Console.WriteLine("\nTotal students: " + totalStudents.Count);
    }

    public static void PrintCollection<T>(IEnumerable<T> collection) {
        foreach (T item in collection) {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
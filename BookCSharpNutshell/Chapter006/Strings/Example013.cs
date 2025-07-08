using System.Text;

namespace Chapter006.Strings;

public static class Example013 {
    public static void Run() {
        // StringBuilder append data

        {
            const int min = 100;
            const int max = 110;
            var sb = new StringBuilder();

            for (int i = min; i < max; i++) {
                sb.Append(char.ConvertFromUtf32(i) + " ");
            }

            Console.WriteLine(sb.ToString());
        }

        Console.WriteLine();

        {
            string[] names = ["Diego", "Amanda", "Amora", "Ameixa"];

            var sb = new StringBuilder();

            sb.AppendJoin(", ", names);

            Console.WriteLine(sb.ToString());
        }

        Console.WriteLine();

        {
            const string name1 = "Diego";
            const string name2 = "Amanda";

            var sb = new StringBuilder();

            sb.AppendLine(name1);
            sb.Append(name2);

            Console.WriteLine(sb.ToString());
        }
    }
}
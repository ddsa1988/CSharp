namespace Basics.S005_Methods;

public static class MethodParameterOut {
    public static void UserMain() {
        {
            bool result = IntTryParse("Diego", out int number);

            if (result) {
                Console.WriteLine("The number is: " + number);
            } else {
                Console.WriteLine("Couldn't parse the string value.");
            }
        }

        Console.WriteLine();

        {
            bool result = IntTryParse("200", out int number);

            if (result) {
                Console.WriteLine("The number is: " + number);
            } else {
                Console.WriteLine("Couldn't parse the string value.");
            }
        }

    }

    private static bool IntTryParse(string str, out int result) {
        try {
            result = int.Parse(str);
            return true;
        } catch (Exception e) {
            Console.Error.WriteLine(e.Message);
        }

        result = 0;
        return false;
    }
}

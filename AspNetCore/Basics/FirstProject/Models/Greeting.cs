namespace FirstProject.Models;

public static class Greeting {
    public static string GetGreeting() {
        const int midday = 12;

        int hour = DateTime.Now.Hour;

        return hour < midday ? "Good Morning" : "Good Afternoon";
    }
}
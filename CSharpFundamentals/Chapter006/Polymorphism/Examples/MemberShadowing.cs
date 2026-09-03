using Polymorphism.Models;

namespace Polymorphism.Examples;

internal static class MemberShadowing {
    internal static void Run() {
        var student = new Student("John Doe");

        student.Display();

        ((Person)student).Display(); // Explicit cast to access shadowed member
    }
}
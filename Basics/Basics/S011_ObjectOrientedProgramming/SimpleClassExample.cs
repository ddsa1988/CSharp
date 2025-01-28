using Basics.S011_ObjectOrientedProgramming.Models;

namespace Basics.S011_ObjectOrientedProgramming;

public static class SimpleClassExample {
    public static void UserMain() {
        Car? myCar = null;

        Console.WriteLine((myCar == null) + "\n");

        myCar = new Car();

        Console.WriteLine((myCar == null) + "\n");

        if (myCar == null) return;

        myCar.PetName = "Henry";
        myCar.CurrentSpeed = 10;

        for (int i = 0; i <= 10; i++) {
            myCar.SpeedUp(5);
            myCar.PrintState();
        }
    }
}
namespace CSharpBasics.Chapter01;

public class NumericTypes {
    /*
    Integer signed: sbyte (8 bits), short (16 bits), int (32 bits), long (64 bits).
    Integer unsigned: byte (8 bits), ushort (16 bits), uint (32 bits), ulong (64 bits).
    Real: float (32 bits), long (64 bits), decimal (128 bits).
    */
    public static void MyMain() {
        {
            const int x = 127; //Decimal notation
            const int y = 0x7F; //Hexadecimal notation
            const int z = 0b0111_1111; //Binary notation

            const int million = 1_000_000; //we can use underscore with numeric literal to make it more readable.
            const float f = 4.5F; // To represent a float type is necessary to use the suffix "F or f".
            const decimal d = 1.23M; // To represent a decimal type is necessary to use the suffix "M or m".

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(million);
            Console.WriteLine(f);
            Console.WriteLine(d);
        }

        {
            const int i1 = 10;
            const float f1 = i1; //Implicit conversion from int to float

            const float f2 = 10.75F;
            const int i2 = (int)f2; //Explicit conversion from float to int

            Console.WriteLine(i1);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(i2);
        }

        {
            const decimal m = 1.0M / 6.0M;
            const double d = 1.0 / 6.0;
            /*
             Decimal works in base 10 and can precisely represent numbers expressible in base 2, 5 and 10. 
             
             Float and double internally works in base 2. For this reason, only numbers expressible 
             in base 2 are represented precisely.
            */

            Console.WriteLine(m);
            Console.WriteLine(d);
        }
    }
}
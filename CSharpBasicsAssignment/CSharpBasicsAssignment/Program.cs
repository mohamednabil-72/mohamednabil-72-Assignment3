/* .csproj:
 Contains project settings such as the target framework,
 output type, implicit usings, and nullable settings.

 Program.cs:
 Contains the main application code and uses an explicit Main method.

 obj/:
 Contains intermediate build files generated during the build process.

 bin/:
 Contains the final compiled output of the project. */

namespace CSharpBasicsAssignment;

/* A file-scoped namespace removes one level of indentation
 because the rest of the file automatically belongs to this namespace
 without requiring an additional pair of braces. */

class Program
{
    static void Main()
    {
        RunTypesDemo();
    }
    public static void RunTypesDemo()
    {
        int x = 10;
        long y = 100000000000;
        double q = 10.4;
        decimal m = 2.4m;
        bool z = false;
        string s = "Mohamed NAbil";
        char c = 'a';
        var v = 5;
        Console.WriteLine($"int: {x} - {x.GetType()}");
        Console.WriteLine($"long: {y} - {y.GetType()}");
        Console.WriteLine($"double: {q} - {q.GetType()}");
        Console.WriteLine($"decimal: {m} - {m.GetType()}");
        Console.WriteLine($"bool: {z} - {z.GetType()}");
        Console.WriteLine($"char: {c} - {c.GetType()}");
        Console.WriteLine($"string: {s} - {s.GetType()}");
        Console.WriteLine($"var: {v} - {v.GetType()}");
        //implicit conversion
        int number = 100;
        long bigNumber = number;
        char letter = 'c';
        int letterInt = letter;
        Console.WriteLine($"Inplicit int to long {bigNumber}");
        Console.WriteLine($"Inplicit char to int {letterInt}");
        /* No cast is required because these conversions are safe
        and C# performs them implicitly.*/

        //Explicit converaion
        double decimalNumber = 5.5;
        int castResult = (int)decimalNumber;
        int convertResult = Convert.ToInt32(decimalNumber);
        Console.WriteLine(castResult);
        Console.WriteLine(convertResult);
        /*
          Casting remove the fractional part, while
        Convert.ToInt32 rounds the value to the nearest integer.
         */

        // 4. Integer division
        int integerDivision = 5 / 2;
        double doubleDivision = 5.0 / 2;

        Console.WriteLine(integerDivision);
        Console.WriteLine(doubleDivision);
        // Integer division keeps only the integer result,
        // while double division keeps the fractional part.
       //boxing/unboxing
        int number2 = 33;
        object boxedNumber = number2;
        int unboxedNumber = (int)boxedNumber;
        Console.WriteLine(unboxedNumber);

        //parsing
        string number3 = "33";
        int parsedNumber = int.Parse(number3);
        Console.WriteLine(parsedNumber);

        bool parseSucceeded = int.TryParse(s, out int res);
        Console.WriteLine(parseSucceeded);
        // TryParse returns false instead of throwing an exception
        // when the string cannot be converted to an integer.

        float w = 10.5f;
        // This implicit conversion is not allowed by C#.
        decimal p = (decimal)w;
        Console.WriteLine(p);

    }
}

// This project uses the newer .slnx solution format.
// The classic .sln format is more widely supported by older tools
// and older versions of Visual Studio.
 
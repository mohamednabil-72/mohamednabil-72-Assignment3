

using System.Drawing;

namespace CSharpBasicsAssignment;



class Program
{
    static void Main()
    {
        RunTypesDemo();
        RunValueVsReferenceDemo();


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
    public struct point
    {
        public int X;
        public int Y;
    }
    public static void RunValueVsReferenceDemo()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 99;

        Console.WriteLine($"p1.X = {p1.X}");
        Console.WriteLine($"p2.X = {p2.X}");
        // struct is a value type.
        // therefore,changhing p2 does not affect p1.
        Order o1 = new Order
        {
            OrderId = 1,
            CustomerName = "Mohamed",
            Quantity = 2,
            UnitPrice = 100m,
            DiscountPercent = 10,
            ShippingCity = "Assiut",
            Priority = 'H',
            ItemCode = 12345L,
            IsPaid = false
        };
        o1.CalculateTotal();
        Order o2 = o1;
        o2.IsPaid = true;
        // Order is a reference type, so o1 and o2 refer to the same object.
        // Changing the object through o2 also changes what o1 sees.

        Console.WriteLine($"o1.IsPaid = {o1.IsPaid}");
        Console.WriteLine($"o2.IsPaid = {o2.IsPaid}");
        object boxedOrder = o1;

        // No actual boxing occurs here because Order is already a reference type.
        // The object variable simply stores the same reference.

        Order o3 = (Order)boxedOrder;
        Console.WriteLine($"Same object: {object.ReferenceEquals(o1, o3)}");

        o2.PrintSummary();
        /*
         Value types store their values directly, while reference types store a reference to an object.
          For a value type, assignment copies the actual value, so each variable has its own copy.
          For a reference type, assignment copies the reference, so both variables can refer to the same object on the heap.
          Storing a reference type in an object variable does not create a new object; it only stores the same reference.
         */
    }
}



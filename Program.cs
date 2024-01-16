using System;
namespace Nullable
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            Console.WriteLine(a.HasValue); //HasValue property is false

            a = 6;//assign value to variable
            Console.WriteLine(a.HasValue); //hasvalue property is true because a has non-null value
            Console.WriteLine(a.Value);  //returns value of a
            Console.WriteLine(a);
            Console.Read();


        }
    }
}
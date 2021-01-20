using System;
using System.Collections.Generic;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "engin","talha","buğra"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("arda");
            Console.WriteLine(isimler2[4]);

        }
    }
}

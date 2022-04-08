using System;
using System.Collections.Generic;
using System.Linq;

namespace TorturaParaExplicarPorQueUsarLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosList = new List<int>() { 3,6,2,9,7,4,1,7,8 };
            numerosList.Sort((num1, num2) => num1 - num2);
            //

            foreach (var value in numerosList)
                Console.WriteLine(value);
        }
    }
}


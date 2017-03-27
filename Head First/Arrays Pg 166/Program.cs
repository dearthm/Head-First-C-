using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Pg_166
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] myArray = new bool[15];
            myArray[4] = true;
            myArray[11] = true;
            myArray.ToList().Sort();

            foreach (bool value in myArray)
            {
                Console.WriteLine("myArray Element 4= " + value);
            }
            
            Console.Read();

        }
    }
}

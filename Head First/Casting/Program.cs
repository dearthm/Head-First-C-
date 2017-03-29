using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
       { 
            Console.WriteLine("Please enter a number...");

            int outNum;
            //TryParse returns true if successful.
            //The 'out' command then sends the value to the variable outNum
            bool result = Int32.TryParse(Console.ReadLine(), out outNum);

            if(result)
            {
                
                Console.WriteLine("Conversion was succesful!");
                Console.WriteLine("Number is " + outNum);
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }


        }

    }
}

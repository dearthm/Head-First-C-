using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //The' T' & 'U' substitute new 'Types' i.e int or String
    //See below
    class Pair<T,U>
    {

        public T First { get; set; }
        public U Second { get; set; }
        public override string ToString()
        {
            return "{" + First + "," + Second + "}";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //
            Pair<int, int> p = new Pair<int, int> { First = 66,Second=108 };
            Pair<string, string> p1 = new Pair<string, string> { First = "Jim",Second="Karen" };
            Pair<string, string> p2 = new Pair<string, string> { First = "Joe",Second="Jane" };
            Pair<string, string> p3 = new Pair<string, string> { First = "Suzy",Second="Bob" };
            Pair<string, string> p4 = new Pair<string, string> { First = "Suzy",Second="Bill" };

            Console.WriteLine(p1.ToString());
            Console.ReadKey();
        }
    }
}

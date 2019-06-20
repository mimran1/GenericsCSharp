using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create generic class with int
            GenericList<int> listInt = new GenericList<int>();
            listInt.AddHead(1);
            listInt.AddHead(2);
            listInt.AddHead(3);
            listInt.AddHead(4);

            System.Console.Write("Stack of integer: ");
            foreach (int i in listInt)
                System.Console.Write(i + " ");
            
            System.Console.WriteLine("\n");
            

            //Create generic class with String

            GenericList<string> listString = new GenericList<string>();
            listString.AddHead("A");
            listString.AddHead("B");
            listString.AddHead("C");
            listString.AddHead("D");

            System.Console.Write("Stack of string: ");
            foreach (string i in listString)
                System.Console.Write(i + " ");
            

            System.Console.WriteLine("\n\nDone.");
            Console.ReadKey();

        }
    }
}

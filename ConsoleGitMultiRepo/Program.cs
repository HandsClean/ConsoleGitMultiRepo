
using System;
using System.Xml.Linq;
using TestClassLib;

namespace ConsoleGitMultiRepo
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person {Age = 21, Name = "Art"  };
            person.Name = "Jim";

            XElement x;

            XElement xxxmergessexperiment;
            //test









            var array = new int[12] { 1, 5, 6, 12, 768, 12, 6, 8, 13, 67, 23, 21 };
          //  array ={ 1,5,6,12,768,12,6,8,13,67,23,21};
            var doublearray = new double[,] { { 1, 2 }, { 2, 3 }, { 4, 5 } };
          
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!5");
            Console.WriteLine("Hello World!6");
            Console.WriteLine("testbranch");
            var circqueue = new CircularQueue<int>(3);
            circqueue.TryAppend(21);
            circqueue.TryAppend(22);
            circqueue.TryAppend(23);
            circqueue.TryAppend(24);
            circqueue.TryAppend(25);
            //  var data = circqueue.Data;
            Console.WriteLine(circqueue.GetData().ToString());
            var arrahisto = new int[6] { 2, 1, 5, 6, 2, 3 };
            var solutionHisto = new LargestRectangleInHistoSolution();
            var areamax = solutionHisto.largestRectangleArea(arrahisto);

        }
    }
}

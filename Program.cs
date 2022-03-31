using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.BL;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tf = false;
            clock a = new clock();
            clock b = new clock(8);
            clock c = new clock(8, 10);
            clock d = new clock(8, 10, 10);
            clock e = new clock(8, 10, 10);

            
            Console.Write("Empty Time : ");
            a.printObject();
            
            Console.Write("Hour time : ");
            b.printObject();
            
            Console.Write("Minute Time : ");
            c.printObject();
            
            Console.Write("Second time : ");
            d.printObject();

            Console.Write("Full Time(Increment Seconds) : ");
            d.incrementInSeconds();
            d.printObject();

            Console.Write("Full Time(Increment Minutes) : ");
            d.incrementInMinutes();
            d.printObject();

            Console.Write("Full Time(Increment Hours) : ");
            d.incrementInHour();
            d.printObject();

            Console.Write("Flag : ");
            tf = d.manualTimingInput(9, 11, 11);
            Console.WriteLine(tf);

            Console.Write("Object Flag : ");
            tf = d.objectTimingInput(e);
            Console.WriteLine(tf);
            Console.ReadKey();
        }
    }
}

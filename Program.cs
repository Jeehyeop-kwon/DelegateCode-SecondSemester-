using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLabSpring
{
    class Program
    {
        static void Main(string[] args)
        {  //this is practising delegate
            PrintingDelegate printingDelegate = 
                new PrintingDelegate(PrintAddress); 
            Student student = new Student();
            printingDelegate += student.PrintName; 
            printingDelegate("delegate running.");

            //event lab

            student.StartWorking += new PrintingDelegate(PrintAddress);
            student.StartWorking += PrintAddress;
            student.StartWorking += student.PrintName;
            student.StartWorking -= PrintAddress;

            student.OnStartWorking("Event fired."); 


        }

        static void PrintAddress(string address)
        {
            Console.WriteLine(address + "__static method printed this.");
            Console.WriteLine("Reporting to the manager."); 
        }
    }
}

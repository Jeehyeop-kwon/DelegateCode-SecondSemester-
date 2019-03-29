using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLabSpring
{
    public delegate void PrintingDelegate(string message);

    public class Student
    {
        public void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        public event PrintingDelegate StartWorking;

        public void OnStartWorking(string messageStart)
        {
            //StartWorking s = new StartWorking(); 
            StartWorking(messageStart);
        }
    }
}

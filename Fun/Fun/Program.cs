using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fun
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int x = 0;
            while (x>20)
            {
                Console.WriteLine("Problemler Aranıyor !!");
                Thread.Sleep(1);
                Console.WriteLine("Bir sorun bulamadık !!");
                x = x + 1;
                
            }
            
        }
    }
}

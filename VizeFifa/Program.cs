using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeFifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.Ad = "Batshuayi";
            futbolcu1.Yas = 30;
            futbolcu1.Mevki = "Forvet";
            futbolcu1.No = 11;
            futbolcu1.FutbolcuOzellikler();

            Futbolcu futbolcu2 = new Futbolcu();
            futbolcu2.Ad = "Ferdi Kadıoglu";
            futbolcu2.Mevki = "Sol Bek";
            futbolcu2.No = 20;
            futbolcu2.Yas = 25;
            futbolcu2.FutbolcuOzellikler();


            Console.ReadLine();
                }
    }

    public class Futbolcu
    {
        public int Yas { get; set; }
        public int No { get; set; }
        public string Ad { get; set; }
        public string Mevki { get; set; }

        public Futbolcu()
        {
            Console.WriteLine("Fenerbahçe futbolcusu oluşturuldu");
        }

        public void FutbolcuOzellikler()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Yas);
            Console.WriteLine(No);           
            Console.WriteLine(Mevki);

        }
    }

    
}

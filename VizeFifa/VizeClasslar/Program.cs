using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeClasslar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolcular Livakovic = new Futbolcular();
            Console.WriteLine("Livakovic");
            Console.WriteLine("---------------");
            Livakovic.Rating = 91;
            Livakovic.Mevki = "Kaleci";          
            Livakovic.SağAyak();
            Console.WriteLine(Livakovic.Mevki);
            Console.WriteLine("Rating :" + Livakovic.Rating);
            Console.WriteLine("  ");

            Futbolcular Tadic = new Futbolcular();

            Console.WriteLine("Tadic");
            Console.WriteLine("---------------");
            Tadic.Mevki = "Sol Açık";
            Tadic.Rating = 94;
            Tadic.SolAyak();
            Console.WriteLine(Tadic.Mevki);
            Console.WriteLine("Rating :" + Tadic.Rating);






            Console.ReadLine();

        }
    }

    public class Futbolcular
    {
        public int Rating { get; set; }
        public string Mevki { get; set; }
        
        public void SolAyak () 
        {
            Console.WriteLine("Sol ayaklı Futbolcu");
        }

        public void SağAyak()
        {
            Console.WriteLine("Sağ ayaklı Futbolcu");
        }

        public Futbolcular()
        {
            Console.WriteLine("Fenerbahçe futbolcusu oluşturuldu");
        }
    }

    
}

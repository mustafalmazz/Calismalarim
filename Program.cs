using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneSınav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.ad = "mustafa";
            Console.WriteLine(personel.ad);

            Console.ReadLine();
        }
       public class Personel
        {
            public string ad {  get; set; }
            public string soyad { get; set; }
            public string tckn { get; set; }

            public Personel()
            {
                Console.WriteLine("Çalıştı");
            }
            //public Personel()
            //{
            //    Console.WriteLine("Yapıcı metod çalıştı.");
            //
        }
        }
    }
        


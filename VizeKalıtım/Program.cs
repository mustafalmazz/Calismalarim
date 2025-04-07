using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeKalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvan_ad = "Garfield";
            kedi.hayvan_rengi = "turuncu";
            kedi.hayvan_cinsiyet = "Erkek";
            kedi.hayvanOzellikleri();

            Tadic tadic = new Tadic();
            tadic.FutbolcuAdi = "Tadic";
            tadic.FutbolcuMevki = "Sol açık";
            tadic.Futbolcuyasi = 34;
            tadic.FutbolcuNumarasi = 10;
            tadic.FutbolcuOzellikler();

            Console.ReadLine();
        }
        
    }

    public class Hayvan
    {
        public string hayvan_ad;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        private int hayvan_yasi;

        public void hayvanOzellikleri()
        {
            Console.WriteLine(hayvan_ad);
            Console.WriteLine(hayvan_rengi);
            Console.WriteLine(hayvan_cinsiyet);

        }


    }

    public class Kedi : Hayvan 
    {
        
    }


    public class Futbolcu
    {
        public string FutbolcuAdi;
        public int FutbolcuNumarasi;
        public int Futbolcuyasi;
        public string FutbolcuMevki;

        public void FutbolcuOzellikler()
        {
            Console.WriteLine(FutbolcuAdi);
            Console.WriteLine(FutbolcuNumarasi);
            Console.WriteLine(Futbolcuyasi);
            Console.WriteLine(FutbolcuMevki);

        }
    }

    public class Tadic : Futbolcu
    {

    }
}

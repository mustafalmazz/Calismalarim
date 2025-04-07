using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Koleksiyonlar";
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Gökhan"); //0.indis
            koleksiyon.Add(123);//1.indis
            koleksiyon.Add(true);//2.indis
            koleksiyon.Add(Math.PI);
            string[] dizi =  {"A","B","C" };//a 4. , b 5. c 6. indis olur
            koleksiyon.AddRange(dizi);
            // koleksiyon.Clear(); temizler
            //koleksiyon.Remove("C"); C yi siler"

            Console.WriteLine(koleksiyon[2]);

            foreach (var item in koleksiyon)
            {
                Console.WriteLine(item);
            }

            List<string> FbForvetler = new List<string>();

            FbForvetler.Add("Edin Dzeko");
            FbForvetler.Add("Batshuayi");
            FbForvetler.Add("Umut Nayir");

            foreach(var item in FbForvetler)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

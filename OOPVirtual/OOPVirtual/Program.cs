using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVirtual
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            //Terlik terlik = new Terlik();
            //terlik.Bilgi();

            //Kalem kalem = new Kalem();
            //kalem.Bilgi();
            #endregion
            #region Ornek2
            //Maymun maymun = new Maymun();
            //maymun.Konus();

            //Inek inek = new Inek();
            //inek.Konus();
            //Console.ReadKey();
            #endregion
            #region Ornek3
            Ucgen ucgen = new Ucgen(3,4);
            Console.WriteLine(ucgen.Alanhesapla()); ;
            Console.ReadLine();
            #endregion
        }

    }
    #region Ornek1
    class Obje
    {
        public virtual void Bilgi() {
            Console.WriteLine("Objeyim");


        }

    }


    class Terlik : Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Terliğim");
        }
    }

    class Kalem  :Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Kalemim");
        }
    }
    #endregion

    #region Ornek2
    //class Memeli
    //{
    //    public virtual void Konus()
    //    {
    //        Console.WriteLine("Konuşmuyorum");
    //    }
    //}


    //class Maymun : Memeli
    //{
    //    public override void Konus()
    //    {
    //        Console.WriteLine("maymunum");
    //    }
    //}

    //class Inek : Memeli
    //{
    //    public override void Konus()
    //    {
    //        Console.WriteLine("İneğim");
    //    }
    //}



    #endregion

    #region Ornek3
    public  class Sekil
    {
        public int _boy;
        public int _en;

        public Sekil(int boy , int en)
        {
            _boy = boy;
            _en = en;
        }
        public virtual int Alanhesapla()
        {
            return  0;
        }
    }

    class Ucgen : Sekil
    {
        public Ucgen(int boy , int en) : base(boy , en) //base class ctoru parametre alıyorsa bu zorunludur
        {
            
        }

        public override int Alanhesapla()
        {
            return _boy*_en/2;
        }
    }


    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en) //base class ctoru parametre alıyorsa bu zorunludur
        {

        }
        public override int Alanhesapla()
        {
            return _boy * _en;
        }
    }

    class Dikdortgen : Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy, en) //base class ctoru parametre alıyorsa bu zorunludur
        {

        }
        public override int Alanhesapla()
        {
            return _boy * _en;
        }

    }
    #endregion


}

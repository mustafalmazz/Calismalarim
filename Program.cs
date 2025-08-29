using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace abstracts
{
    public class Program
    {
        static void Main(string[] args)
        {

            Ornek ornek = new Calisma();

        }
    }




    abstract class Ornek
    {
        public abstract void X();

        public abstract int y { get; set; }

    }

    class Calisma : Ornek
    {
        public override int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void X()
        {
            throw new NotImplementedException();
        }
    }
}

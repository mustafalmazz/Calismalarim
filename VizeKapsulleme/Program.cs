using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme2
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Emlak
    {
        public string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value; }
        }

        public string RENK
        {
            get { return renk; }
            set { renk = value; }
        }

    }
}

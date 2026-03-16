using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon___Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nikola Misic

            Tacka prva = new Tacka();
            Tacka a = new Tacka(1, 2);
            Tacka b = new Tacka(2, 3);
            Vektor ab = new Vektor(a, b);
            Tacka c = ab.Centriraj();
            Console.WriteLine(c.d());
        }
    }
}

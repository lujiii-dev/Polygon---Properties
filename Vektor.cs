using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon___Properties
{
    internal class Vektor
    {
        Tacka Pocetak, Kraj;

        public Vektor(Tacka a, Tacka b)
        {
            Pocetak = a;
            Kraj = b;
        }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka(Kraj.x - Pocetak.x, Kraj.y - Pocetak.y);
            return Nova;
        }
        public float SP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.x + aC.y * bC.y;
        }
        public float VP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.y - bC.x * aC.y;
        }
    }
}

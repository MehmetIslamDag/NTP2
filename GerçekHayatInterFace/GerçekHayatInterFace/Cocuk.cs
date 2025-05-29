using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerçekHayatInterFace
{
    class Cocuk : IOyunOynayan,IOkulaGiden,ITuvaleteGiden
    {
        public void OkulaGiden()
        {
            Console.WriteLine("Ben bir çocuğum ve zorunlu olarak okula giderim");
        }

        public void OyunOynayar()
        {
            Console.WriteLine( " ben bir Öocuk Olarak oyun Oynarım");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("Ben Tuvalete Giderim");
        }
    }
}

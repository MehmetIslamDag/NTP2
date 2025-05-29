using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerçekHayatInterFace
{
    class Anne : IYemekYapan,ICocukBakan,ITuvaleteGiden
    {
        public void CocukBakan()
        {
            Console.WriteLine("Ben Bir Anneyim Çocuklarıma Bakarım");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("Bir Anne Olsamda Tuvalete Giderim");
        }

        public void YemekYapan()
        {
            Console.WriteLine(" Ben Bir Anneyim Ymek Yaparım");
        }
    }
}

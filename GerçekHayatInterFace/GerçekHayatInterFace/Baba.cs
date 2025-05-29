using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerçekHayatInterFace
{
    class Baba : IArabaSuren,ITuvaleteGiden,ICalısan,ICocukBakan
    {
        public void ArabaSuren()
        {
            Console.WriteLine(" Ben Araba Sürebilirim");
        }

        public void Calısan()
        {
            Console.WriteLine(" Ben Bir Baba Olarak Evimi Geçindirmek İçin Çalışırım");
        }

        public void CocukBakan()
        {
            Console.WriteLine( " ben Bir Baba Olarak Çocuğuma Bakarım");
        }

        public void TuvaleteGiden()
        {
            Console.WriteLine("Ben Bir Baba Olarak Tuvalete Giderim");
        }

        
    }
}

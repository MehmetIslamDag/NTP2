using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerçekHayatInterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            Baba baba = new Baba();
            Anne anne = new Anne();
            Cocuk cocuk = new Cocuk();

            baba.ArabaSuren();
            baba.Calısan();
            baba.CocukBakan();
            baba.TuvaleteGiden();

            anne.TuvaleteGiden();
            anne.CocukBakan();
            anne.YemekYapan();

            cocuk.TuvaleteGiden();
            cocuk.OyunOynayar();
            cocuk.OkulaGiden();


        }
    }
}

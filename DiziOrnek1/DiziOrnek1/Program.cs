using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    //Dizi Tanımı:
    //Aynı Türden birden fazla verinin tutulduğu yapılardır
    //sabit bir uzunlağa sahiptir
    //indeks numarası sıfırdan başlar
    //dizi oluştururken önce türünü sonrada boyutunu tanımlamak gerekir
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiler; //int türünden bir dizi tanımnlandı
            sayiler = new int[5]; // diziye 5 elemanlık yer ayrıldı
            sayiler[0] = 10;
            sayiler[1] = 20;
            sayiler[2] = 30;
            sayiler[3] = 40;
            sayiler[4] = 50;
            //dizinin inekslerinden yararlanarak değer atadık
            Console.WriteLine(sayiler[0]);
            Console.WriteLine(sayiler[1]);
            Console.WriteLine(sayiler[2]);
            Console.WriteLine(sayiler[3]);
            Console.WriteLine(sayiler[4]);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList ogrenciler = new SortedList();

            ogrenciler.Add(1932, "Arda");
            ogrenciler.Add(72, "yusuf");
            ogrenciler.Add(308, "Berkay");

            ogrenciler.Remove(308);
            ogrenciler[72] = "Eyüp";
            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + "-" + eleman.Value);

            }
            Console.ReadLine();
        }
    }
}

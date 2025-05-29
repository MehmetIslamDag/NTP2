using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHTABLEUYG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ogrenciler = new Hashtable();
            ogrenciler.Add(43, "Damla");
            ogrenciler.Add(286, "Mehmet İslam");
            ogrenciler.Add(147, "Baki");
            ogrenciler.Add("yusuf", 72);


            ogrenciler.Remove(43);
            ogrenciler.Remove("burak");


            ogrenciler[147] = "emirhan";
            ogrenciler["ipek"] = 205;


            foreach (var anahtar in ogrenciler.Values)
            {
                Console.WriteLine(anahtar);

            }
            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + "-" + eleman.Value);
                Console.ReadLine();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipakka_1511
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kortti k = new Kortti("Hertta", 2);
            //Console.WriteLine(k);

            /*List<Kortti> pakka = new List<Kortti>();

            string[] maat = {"Hertta", "Ruutu", "Risti", "Pata" };

            for (int i = 0; i < maat.Length; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Kortti k = new Kortti(maat[i], j);
                    pakka.Add(k);
                }
            }

            // Sekoita pakka

            // Selvitä, miten c#-lista sekoitetaan
            // Google: c# shuffle list

            // Tulostetaan pakka

            foreach (var kortti in pakka)
            {
                Console.WriteLine(kortti);

            }*/

            Korttipakka korttipakka = new Korttipakka();

            korttipakka.Sekoita();

            Console.WriteLine(korttipakka.ToString());

            korttipakka.Jarjesta();

            Console.WriteLine(korttipakka.ToString());

            List<Kortti> kasi = korttipakka.Jaa(3);
            foreach (var kortti in kasi)
            {
                Console.WriteLine(kortti);
            }

            Console.WriteLine("Pakassa jäljellä ");
            Console.WriteLine(korttipakka.ToString());

            Console.ReadLine();
        }
    }
}
